using System;
using System.Security.Claims;
using Dodos.UI.Helpers.Security;
using Dodos.UI.Models;
using Dodos.UI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dodos.UI.Controllers
{
    [AllowAnonymous]
    [Produces ("application/json")]
    [Route ("api/Login")]

    public class LoginController : Controller {
        private readonly Loginservices loginservices;
        private readonly Common_Connectionservices Connectionservices;
        public LoginController (Loginservices loginservices, Common_Connectionservices concservice) {
            this.loginservices = loginservices;
            this.Connectionservices = concservice;
        }

        [HttpGet]
        public IActionResult GetLoginDetails (string AppUserName, string AppUserPassword, string productcode) {
            Common_ConnectionModel objconnectionmodel = new Common_ConnectionModel();
            objconnectionmodel.ProductCode = productcode;
            var connectionstring = Connectionservices.getconnectiondetails(objconnectionmodel.ProductCode);
            string constring = connectionstring.ConnectionString.ToString();
            MyBloggingContext.cn = @constring;
            LoginModel objAppUser = new LoginModel ();
            objAppUser.AppUserName = AppUserName;
             objAppUser.AppUserPassword = AppUserPassword;
            return new OkObjectResult (loginservices.getlogindetails (objAppUser.AppUserName, objAppUser.AppUserPassword));
        }

        [HttpPost]
        public IActionResult Post ([FromBody] LoginModel loginModel) {
            var result = GetLoginDetails (loginModel.AppUserName,loginModel.AppUserPassword,"KS0001");

            var token = new JwtTokenBuilder ()
                .AddSecurityKey (JwtSecurityKey.Create ("Kosoft.Security.Key"))
                .AddSubject (loginModel.AppUserName)
                .AddIssuer ("Kosoft.Security.Bearer")
                .AddAudience ("Kosoft.Security.Bearer")
                .AddClaim (ClaimTypes.Role, "User")
                .AddExpiry (5)
                .Build ();

            Console.Write (HttpContext.User);
            return Ok (token.Value);

        }

    }
}