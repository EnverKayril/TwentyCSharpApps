﻿namespace _05_ApiWeather.Entities
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string Country { get; set; }
        public decimal Temprature { get; set; }
        public string Detail { get; set; }
    }
}