using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers {
    [Route("api/cities")]
    public class CitiesController : Controller {

        [HttpGet()]
        // GET
        public IActionResult GetCities() {
               return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id) {
            var cityResult = CitiesDataStore.Current.Cities.FirstOrDefault(c=>c.Id==id);
            if (cityResult == null) {
                return NotFound();
            }

            return Ok(cityResult);
        }
    }
}