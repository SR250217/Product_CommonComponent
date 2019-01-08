using System;
using System.Security.Claims;
using Dodos.UI.Helpers.Security;
using Dodos.UI.Models;
using Dodos.UI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dodos.UI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [Authorize]
    public class CountriesController : Controller
    {
        private readonly Countriesservices countriesservice;
        private readonly Citiesservices citiesservice;
        private readonly Statesservices statesservice;
        public CountriesController(Countriesservices countriesservice, Citiesservices citiesservice, Statesservices statesservice)
        {
            this.countriesservice = countriesservice;
            this.citiesservice = citiesservice;
            this.statesservice = statesservice;
        }
        // public CountriesController(Countriesservices countriesservice)
        // {
        //     this.countriesservice = countriesservice;
        // }
        [HttpGet("GetAllCountries")]
        public IActionResult GetAllCountries()
        {
            return new OkObjectResult(countriesservice.getCountries());
        }
        [HttpGet("GetAllCities/{stateid}")]
        public IActionResult GetAllCities(int stateid)
        {
            return new OkObjectResult(citiesservice.getCities(stateid));
        }
        [HttpGet("GetAllStates/{countryid}")]
        public IActionResult GetAllStates(int countryid)
        {
            return new OkObjectResult(statesservice.getStates(countryid));
        }
    }
}