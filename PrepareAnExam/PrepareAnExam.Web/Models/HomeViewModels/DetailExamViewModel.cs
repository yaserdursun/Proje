using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PrepareAnExam.Web.Models.HomeViewModels
{
    public class DetailExamViewModel
    {

        public List<QuestionViewModel> Question { get; } = new List<QuestionViewModel>();
        public DetailExamViewModel()
        {
            Question1 = new QuestionViewModel();
            Question2 = new QuestionViewModel();
            Question3 = new QuestionViewModel();
            Question4 = new QuestionViewModel();
            AnswerOptions = new List<SelectListItem>
            {
                new SelectListItem {Text="A", Value="A"},
                new SelectListItem {Text="B", Value="B"},
                new SelectListItem {Text="C", Value="C"},
                new SelectListItem {Text="D", Value="D"}
            };
        }

        public string Title { get; set; }
        public string Content { get; set; }

        public QuestionViewModel Question1 { get; set; }
        public QuestionViewModel Question2 { get; set; }
        public QuestionViewModel Question3 { get; set; }
        public QuestionViewModel Question4 { get; set; }

        public List<SelectListItem> AnswerOptions { set; get; }
    }
}
