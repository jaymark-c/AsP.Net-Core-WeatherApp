using Microsoft.AspNetCore.Mvc;
using RazorViews_WeatherApp.Models;
using Services;
using Services.IServices;

namespace RazorViews_WeatherApp.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherService _weatherService;
        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return Json(_weatherService.GetAllCity());

            //return View("Index", _weatherService.GetAllCity());
        }

        [Route("/weather/{cityCode}")]
        public IActionResult WeatherCity(string cityCode)
        {
            
            var city = _weatherService.GetCityByCode(cityCode);

            if(city == null)
            {
                Response.StatusCode = 400;
                return View("InvalidCode");
                //return NotFound("InvalidCode");
            }
            //return Json(city);
            return View("WeatherCity",city);
        }


    }
}
