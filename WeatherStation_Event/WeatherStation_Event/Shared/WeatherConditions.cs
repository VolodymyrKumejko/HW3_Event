﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using OpenWeatherAPI.Wind;
using static OpenWeatherAPI.Wind;

namespace WeatherStation_Event.Shared
{
    class WeatherConditions
    {
        public double CurentTemperature;
        public double MinTemperature;
        public double MaxTemperature;
        public double SeaLevel;
        public double WindSpeedMetersPerSecond;
        public double RainLevel;
        public double Degri;
        public int CountCondition;
        public string Cyti;
        public DirectionEnum Direction;
    }
}
