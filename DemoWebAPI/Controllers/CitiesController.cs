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
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            return Ok(CitiesData.current.Cities);
        }

        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCityById(int id) {
            var city = CitiesData.current.Cities.FirstOrDefault(c => c.Id == id);
            if(city == null)
            {
                return NotFound();
            }
            return Ok(city);
        }

        [HttpPost]
        public ActionResult<CityDto> PostCity(CityDto city) {
            CitiesData.current.Cities.Add(city);
            return Ok(city); 
        }

    }
}
