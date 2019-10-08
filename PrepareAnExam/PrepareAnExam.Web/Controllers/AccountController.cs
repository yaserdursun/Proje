using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PrepareAnExam.Web.DB;
using PrepareAnExam.Web.Models.AccountViewModels;
using PrepareAnExam.Web.Services;

namespace PrepareAnExam.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IDbContext Db;
        private readonly ISignInManager signInManager;
        public AccountController(ISignInManager signInManager, IDbContext db)
        {
            this.signInManager = signInManager;
            Db = db;

        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var user = Db.Users.FirstOrDefault(x => x.UserName.Equals(model.UserName, StringComparison.InvariantCultureIgnoreCase));
                if (user == null)
                {
                    ViewData["Message"] = "Kullanıcı adı yanlış! ";
                    return View(model);
                }

                if (signInManager.GetClaimsPrincipal(model.UserName, model.Password, user, out ClaimsPrincipal principal))
                {
                    await HttpContext.SignInAsync(principal);
                    return RedirectToLocal(returnUrl);
                }
                else
                {
                    ViewData["Message"] = "Yanlış şifre! ";
                }
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

        #region Helpers

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);

            return Redirect("/");
        }

        #endregion

    }
}