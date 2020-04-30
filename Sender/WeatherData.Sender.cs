using Microsoft.Azure.EventHubs;
using Newtonsoft.Json;
using Sender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{
    public interface IWeatherDataSender
    {
        Task SendDataAsync(WeatherData data);
    }
    public class WeatherDataSender : IWeatherDataSender
    {
        private EventHubClient _eventHubClient;

        public WeatherDataSender(string eventHubConnectionString)
        {
            _eventHubClient = EventHubClient.CreateFromConnectionString(eventHubConnectionString);
        }
        public async Task SendDataAsync(WeatherData data)
        {
            EventData eventData = CreateEventData(data);
            await _eventHubClient.SendAsync(eventData);
        }

       private static EventData CreateEventData(WeatherData data)
        {
            var dataAsJson = JsonConvert.SerializeObject(data);
            var eventData = new EventData(Encoding.UTF8.GetBytes(dataAsJson));
            return eventData;
        }
    }
}
