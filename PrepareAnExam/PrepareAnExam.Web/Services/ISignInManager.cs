using PrepareAnExam.Web.DB.Tables;
using System;
using System.Security.Claims;
namespace PrepareAnExam.Web.Services
{
    public interface ISignInManager
    {
        bool GetClaimsPrincipal(string userName, string password, User user, out ClaimsPrincipal principal);
        Tuple<string, string> CreadHashedUser(string password);
    }
}
