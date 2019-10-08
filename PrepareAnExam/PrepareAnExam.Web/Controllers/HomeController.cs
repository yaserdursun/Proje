using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PrepareAnExam.Web.DB;
using PrepareAnExam.Web.DB.Tables;
using PrepareAnExam.Web.Models;
using PrepareAnExam.Web.Models.HomeViewModels;

namespace PrepareAnExam.Web.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        private readonly IDbContext Db;
        private readonly IConfiguration Configuration;
        public HomeController(IDbContext db, IConfiguration configuration)
        {
            Db = db;
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            var rssUrl = Configuration.GetValue<string>("RssUrl");
            var model = ParseRss(rssUrl).ToList();
            return View(model);
        }

        public IActionResult List()
        {
            var model = new List<ListExamViewModel>();
            try
            {
                model = Db.Exams
                    .Where(e => !e.Deleted)
                    .Select(e => new ListExamViewModel
                    {
                        Id = e.Id,
                        Title = e.Title,
                        Created = e.Created
                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                //TODO:loglama
            }

            return View(model);
        }

        public IActionResult Create(string url)
        {
            var model = new CreateExamViewModel();
            model = PreparePostDetailModel(url, model);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(string url, CreateExamViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var exam = new Exam { Title = model.Title, Detail = model.Content};                  
                    exam.Questions.Add(ModelToEntity(model.Question1));
                    exam.Questions.Add(ModelToEntity(model.Question2));
                    exam.Questions.Add(ModelToEntity(model.Question3));
                    exam.Questions.Add(ModelToEntity(model.Question4));
                    
                    Db.Exams.Add(exam);
                    Db.SaveChangesAsync();

                    return RedirectToAction(nameof(List));
                }
            }
            catch (Exception ex)
            {
                ViewData["Message"] = "Bir hata oluştu!";
                //TODO:loglama
            }

            model = PreparePostDetailModel(url, model);
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            try
            {
                var exam = Db.Exams.FirstOrDefault(e => e.Id == id);
                var que = Db.Questions.FirstOrDefault(q => q.ExamId == id);


                if (exam != null)
                {
                    var model = new DetailExamViewModel();

                    model.Title = exam.Title;

                    //...
                    model.Question1 = EntityToModel(que.Exam.Questions[0]);

                    model.Question2 = EntityToModel(que.Exam.Questions[1]);

                    model.Question3 = EntityToModel(que.Exam.Questions[2]);

                    model.Question4 = EntityToModel(que.Exam.Questions[3]);

                    model.Question.Add(model.Question1);
                    model.Question.Add(model.Question2);
                    model.Question.Add(model.Question3);
                    model.Question.Add(model.Question4);

                    ViewBag.RssTitle = exam.Title;
                    ViewBag.RssContent = exam.Detail;

                    //...
                    model.Content = exam.Detail;
                    return View("Detail",model);
                }
            }
            catch (Exception ex)
            {
                //TODO:loglama
            }

            return RedirectToAction(nameof(List));
        }



        [HttpPost]

        public IActionResult CheckAnswer(int id, string IsRight)
        {
            var que = Db.Questions.FirstOrDefault(q => q.ExamId == id);
            if (que.Answer== IsRight)
            {
                return Json("true");
            }
            if (que.Answer != IsRight)
            {
                return Json("false");
            }


            return Json("null");
        }










        public IActionResult Delete(int id)
        {
            try
            {
                var exam = Db.Exams.FirstOrDefault(e => e.Id == id);
                if (exam != null)
                {
                    exam.Deleted = true;
                    Db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                //TODO:loglama
            }

            return RedirectToAction(nameof(List));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        #region Helpers

        private Question ModelToEntity(QuestionViewModel model)
        {
            return new Question
            {
                Detail = model.Detail,
                A = model.A,
                B = model.B,
                C = model.C,
                D = model.D,
                Answer = model.Answer
            };
        }

        private  QuestionViewModel EntityToModel(Question entity)
        {
            return new QuestionViewModel
            {
                Detail = entity.Detail,
                A = entity.A,
                B = entity.B,
                C = entity.C,
                D = entity.D,
                Answer = entity.Answer
            };
        }

        private CreateExamViewModel PreparePostDetailModel(string url, CreateExamViewModel model)
        {
            try
            {
                using (var client = new WebClient())
                {
                    var html = client.DownloadString(new Uri(url));
                    var htmlDoc = new HtmlDocument();
                    htmlDoc.LoadHtml(html);

                    var title = htmlDoc.DocumentNode.SelectNodes("//h1[@class='content-header__row content-header__hed']")
                        .FirstOrDefault()?.InnerText;
                    model.Title = title;

                    var pContent = htmlDoc.DocumentNode
                        .SelectNodes("//div[@class='article__chunks']//div[@class='grid--item body body__container article__body grid-layout__content']//p");
                    model.Content = "";
                    pContent.ToList().ForEach(p =>
                    {
                        model.Content += $"{p.InnerText}\n";
                    });
                }
            }
            catch (Exception ex)
            {
                //TODO: loglama
            }

            return model;
        }

        private IList<RssItemViewModel> ParseRss(string url)
        {
            try
            {
                XDocument doc = XDocument.Load(url);
                var entries = doc.Root.Descendants()
                              .First(i => i.Name.LocalName == "channel")
                              .Elements().Where(i => i.Name.LocalName == "item")
                              .Select(item => new RssItemViewModel
                              {
                                  Description = item.Elements().First(i => i.Name.LocalName == "description").Value,
                                  Link = item.Elements().First(i => i.Name.LocalName == "link").Value,
                                  PublishDate = ParseDate(item.Elements().First(i => i.Name.LocalName == "pubDate").Value),
                                  Title = item.Elements().First(i => i.Name.LocalName == "title").Value
                              });
                return entries.ToList();
            }
            catch
            {
                return new List<RssItemViewModel>();
            }
        }

        private DateTime ParseDate(string date)
        {
            DateTime result;
            if (DateTime.TryParse(date, out result))
                return result;
            else
                return DateTime.MinValue;
        }

        #endregion


    }
}
