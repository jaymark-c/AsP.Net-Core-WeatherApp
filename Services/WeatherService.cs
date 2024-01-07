using Services.Models;
using Services.IServices;

namespace Services
{
    public class WeatherService : IWeatherService
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

        public IEnumerable<CityWeather> GetAllCity()
        {
            return cityWeather;
        }

        public CityWeather? GetCityByCode(string cityCode)
        {
            var city = cityWeather.Where(x => x.CityUniqueCode == cityCode).FirstOrDefault();

            return city;
        }
    }
}