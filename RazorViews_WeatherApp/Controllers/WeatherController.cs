using Microsoft.AspNetCore.Mvc;
using RazorViews_WeatherApp.Models;

namespace RazorViews_WeatherApp.Controllers
{
    public class WeatherController : Controller
    {

        public List<CityWeather> cityWeather = new List<CityWeather> {
            new CityWeather
            {
                CityUniqueCode = "LDN",
                CityName = "London",
                DateAndTime = Convert.ToDateTime("2030-01-01 8:00"),
                TemperatureFahrenheit = 33
            },
            new CityWeather {
                CityUniqueCode = "NYC",
                CityName = "London",
                DateAndTime = Convert.ToDateTime("2030-01-01 3:00"),
                TemperatureFahrenheit = 60
            },
            new CityWeather
            {
                CityUniqueCode = "PAR",
                CityName = "Paris",
                DateAndTime = Convert.ToDateTime("2030-01-01 9:00"),
                TemperatureFahrenheit = 82
            }
        };

        [Route("/")]
        public IActionResult Index()
        {
            //return Json(cityWeather);
            return View(cityWeather);
        }

        [Route("/weather/{cityCode}")]
        public IActionResult WeatherCity(string cityCode)
        {
            var city = cityWeather.Where(x => x.CityUniqueCode == cityCode).FirstOrDefault();

            if(city == null)
            {
                Response.StatusCode = 400;
                return View("InvalidCode");
                //return NotFound("InvalidCode");
            }
            //return Json(city);
            return View(city);
        }


    }
}
