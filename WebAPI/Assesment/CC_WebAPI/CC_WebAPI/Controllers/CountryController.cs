using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CC_WebAPI.Models;

namespace CC_WebAPI.Controllers
{
    public class CountryController : ApiController
    {
      private static List<Country> countries = new List<Country>
      {
        new Country { ID = 1, CountryName = "Italy", Capital = "Rome" },
        new Country { ID = 2, CountryName = "United kingdom", Capital = "London" },
        new Country { ID = 3, CountryName = " Australia", Capital="Canberra"},
        new Country { ID = 4, CountryName= " Spain", Capital="Madrid"}
      };

        [HttpGet]
        public IEnumerable<Country> GetAllCountries()
        {
            return countries;
        }

        [HttpGet]
        public IHttpActionResult GetCountry(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        [HttpPost]
        public IHttpActionResult AddCountry(Country country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            country.ID = countries.Max(c => c.ID) + 1;
            countries.Add(country);

            return CreatedAtRoute("DefaultApi", new { id = country.ID }, country);
        }

        [HttpPut]
        public IHttpActionResult UpdateCountry(int id, Country country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingCountry = countries.FirstOrDefault(c => c.ID == id);
            if (existingCountry == null)
            {
                return NotFound();
            }

            existingCountry.CountryName = country.CountryName;
            existingCountry.Capital = country.Capital;

            return StatusCode(HttpStatusCode.NoContent);
        }

        [HttpDelete]
        public IHttpActionResult DeleteCountry(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }

            countries.Remove(country);
            return StatusCode(HttpStatusCode.NoContent);
        }

    }

}
