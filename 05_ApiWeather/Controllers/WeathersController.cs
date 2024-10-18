using _05_ApiWeather.Context;
using _05_ApiWeather.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _05_ApiWeather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeathersController : ControllerBase
    {
        AppDbContext _context = new AppDbContext();

        [HttpGet]
        public IActionResult WeatherCityList()
        {
            var values = _context.Cities.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateWeatherCity(City city)
        {
            _context.Cities.Add(city);
            _context.SaveChanges();
            return Ok("Şehir Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteWeatherCity(int id)
        {
            var city = _context.Cities.Find(id);
            _context.Cities.Remove(city);
            _context.SaveChanges();
            return Ok("Şehir Silindi");
        }

        [HttpPut]
        public IActionResult UpdateWeatherCity(City city)
        {
            var value = _context.Cities.Find(city.CityId);
            value.CityName = city.CityName;
            value.Country = city.Country;
            value.Detail = city.Detail;
            value.Temprature = city.Temprature;
            _context.SaveChanges();
            return Ok("Şehir Güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetWeatherCityById(int id)
        {
            var city = _context.Cities.Find(id);
            return Ok(city);
        }

        [HttpGet("TotalCityCount")]
        public IActionResult TotalCityCount()
        {
            var totalCity = _context.Cities.Count();
            return Ok(totalCity);
        }

        [HttpGet("MaxTempCityName")]
        public IActionResult MaxTempCityName()
        {
            var value = _context.Cities.OrderByDescending(x => x.Temprature).FirstOrDefault();
            return Ok(value);
        }

        [HttpGet("MinTempCityName")]
        public IActionResult MinTempCityName()
        {
            var value = _context.Cities.OrderBy(x => x.Temprature).FirstOrDefault();
            return Ok(value.CityName);
        }
    }
}
