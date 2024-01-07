using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Models;

namespace Services.IServices
{
    public interface IWeatherService
    {
        public CityWeather GetCityByCode(string cityCode);
        public IEnumerable<CityWeather> GetAllCity();
    }
}
