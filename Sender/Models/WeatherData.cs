using System;
using System.Collections.Generic;
using System.Text;

namespace Sender.Models
{
    public class WeatherData
    {
        public int Temperature { get; set; }
        public int WindSpeed { get; set; }
        public Direction WindDirection { get; set; }

        public enum Direction 
        {
            North, South, East, West 
        }

        public override string ToString()
        {
            return "{ Temp: " + Temperature.ToString() + " *C " 
                 + "| Windspeed: " + WindSpeed.ToString() + " km/h "
                 + "| Wind Direction: " + WindDirection.ToString() + " }";
        }
    }
}
