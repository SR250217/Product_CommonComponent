using System;
using System.Security.Claims;
using Dodos.UI.Helpers.Security;
using Dodos.UI.Models;
using Dodos.UI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dodos.UI.Controllers {
    [Route("api/Employee")]
    //[Authorize]
    public class EmployeeController:Controller
    {
        private readonly Loginservices loginservices;
    public EmployeeController(Loginservices loginservices)
    {
        this.loginservices = loginservices;
    }
    [HttpGet]
        public IActionResult Testapipeer () {
           string ok = "Welcome";
            //return ok;
             return new OkObjectResult (loginservices.getlogindetails (ok, "llll"));
        }
    }
}