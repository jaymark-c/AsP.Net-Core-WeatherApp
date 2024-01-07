using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class CityWeather
    {
        //Copied the models in RazorViews_WeatherApp solution to avoid circular dependencies
        [Required]
        [Display(Name = "City Code: ")]
        public string CityUniqueCode { get; set; }
        [Required]
        [Display(Name = "City Name: ")]
        public string CityName { get; set; }
        public DateTime DateAndTime { get; set; }
        public int TemperatureFahrenheit { get; set; }
    }
}
