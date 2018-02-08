using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers {
    [Route("api/cities")]
    public class CitiesController : Controller {

        [HttpGet()]
        // GET
        public JsonResult GetCities() {
               return new JsonResult(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public JsonResult GetCity(int id) {
            return new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(c=>c.Id==id));
        }
    }
}