using DemoWebAPI.data;
using DemoWebAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebAPI.Controllers
{
    [Route("api/Cities")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        

        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(CitiesData.current.Cities);
        }

        [HttpGet("{id}")]
        public JsonResult GetCityById(int id) {
            var city = CitiesData.current.Cities.FirstOrDefault(c => c.Id == id);
            return new JsonResult(city);
        }

        [HttpPost]
        public JsonResult PostCity(CityDto city) {
            CitiesData.current.Cities.Add(city);
            return new JsonResult(city); 
        }

    }
}
