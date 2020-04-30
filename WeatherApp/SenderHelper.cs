using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sender;
using Sender.Models;

namespace WeatherApp
{
    public class SenderHelper
    {
        WeatherDataSender weatherDataSender;
        
        public SenderHelper(string conn)
        {
            weatherDataSender = new WeatherDataSender(conn);
        }
        
        public async Task SendDataAsync(WeatherData WeatherData)
        {
            try
            {
                await weatherDataSender.SendDataAsync(WeatherData);
                Console.WriteLine($"Sent data: {WeatherData}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        public async void DataSender()
        {
            await SendDataAsync(CreateWeatherData());
        }

        public WeatherData CreateWeatherData()
        {
            return new WeatherData
            {
                Temperature = 35, // in degree celcius
                WindSpeed = 300, // Kmph
                WindDirection = WeatherData.Direction.North
            };
        }
    }
}
