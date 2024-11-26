using ConsoleToWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ConsoleToWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {

        //[BindProperty]
        //public CountryModel Country { get; set; }

        //[HttpPost("")]
        //public IActionResult AddCountry()
        //{
        //    return Ok($"Name = {this.Country.Name} "+
        //        "Population = {this.Country.Population} "+
        //        "Area = {this.Country.Area}");
        //}

        //FromQuery
        //[HttpPost("")]
        //public IActionResult AddCountry([FromQuery] CountryModel model)
        //{
        //    return Ok($"Name = {model.Name}");
        //}

        //FromRoute---------
        //[HttpPost("{name}/{Population}/{Area}")]
        //public IActionResult AddCountry([FromRoute]CountryModel model, [FromQuery] int id)
        //{
        //    return Ok($"Name = {model.Name}");
        //}

        //FromBody
        [HttpPut("{id}")]
        public IActionResult AddCountry([FromRoute]int id,[FromBody] CountryModel model)
        {
            return Ok($"Name = {model.Name}");
        }
    }
}
