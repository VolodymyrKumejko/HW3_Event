using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation_Event.Shared;
using WeatherStation_Event.BAL;

namespace WeatherStation_Event.Window
{
    class Window1
    {
        
        public void Subscribe (WeatherControl weatherControl)
        {
            weatherControl.EventNewWeatherConditions += this.OnNext;
        }

        public void Unsubscribe(WeatherControl weatherControl)
        {
            weatherControl.EventNewWeatherConditions -= this.OnNext;
        }

        public void OnNext(WeatherConditions value)
        {
            Console.WriteLine("Вызвано " + value.Cyti + " Запрос № " + value.CountCondition + " Температура" + value.CurentTemperature);
        }
    }
}
