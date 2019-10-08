using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PrepareAnExam.Web.DB.Tables;

namespace PrepareAnExam.Web.Controllers
{
    public class BaseController : Controller
    {
        protected User GetLoginUser
        {
            get
            {
                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    try
                    {
                        var claims = HttpContext.User.Claims.ToList();

                        int.TryParse(claims.Single(s => s.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid").Value, out int UserId);
                        string UserName = claims.Single(s => s.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name").Value;

                        return new User
                        {
                            Id = UserId,
                            UserName = UserName
                        };
                    }
                    catch (Exception ex)
                    {
                        //loglama
                    }
                }
                return null;
            }
        }
    }
}
