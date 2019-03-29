using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation_Event.Shared;

namespace WeatherStation_Event.BAL
{
    class WeatherControl
    {
        public event Action<WeatherConditions> EventNewWeatherConditions;
        WeatherConditions weatherConditionsOld = new WeatherConditions();
        public int countGet;

        public WeatherControl(Action<WeatherConditions> action)
        {
            EventNewWeatherConditions += action;
        }

        public WeatherControl()
        {
        }

        public void GetWeather(string city)
        {
            WeatherConditions weatherConditions = new WeatherConditions();

            var client = new OpenWeatherAPI.OpenWeatherAPI("d9a69d574ef7c5bdccdc52b2b0b13458");

            var results = client.Query(city);
            if (client != null)
            {
                weatherConditions.CurentTemperature = results.Main.Temperature.CelsiusCurrent;
                weatherConditions.Direction = results.Wind.Direction;
                weatherConditions.MaxTemperature = results.Main.Temperature.CelsiusMaximum;
                weatherConditions.MinTemperature = results.Main.Temperature.CelsiusMaximum;
                weatherConditions.SeaLevel = results.Main.SeaLevelAtm;
                weatherConditions.WindSpeedMetersPerSecond = results.Wind.SpeedMetersPerSecond;
                //weatherConditions.RainLevel = results.Rain.H3;
                weatherConditions.Degri = results.Wind.Degree;
                weatherConditionsOld = weatherConditions;
                weatherConditions.Cyti = city;
                countGet += 1;
                weatherConditions.CountCondition = countGet;
                EventNewWeatherConditions(weatherConditions);
            }

        }

    }   
}
