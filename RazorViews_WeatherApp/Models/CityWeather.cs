using System.ComponentModel.DataAnnotations;

namespace RazorViews_WeatherApp.Models
{
    public class CityWeather
    {
        [Required]
        [Display(Name = "City Code: ")]
        public string CityUniqueCode { get; set; }
        [Required]
        [Display(Name = "City Name: ")]
        public string CityName { get; set; }
        public DateTime DateAndTime { get; set; }
        public int TemperatureFahrenheit { get; set; }
        /*
         string CityUniqueCode
         string CityName
         DateTime DateAndTime
         int TemperatureFahrenheit
         */
    }
}
