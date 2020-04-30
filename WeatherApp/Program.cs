using Sender;
using Sender.Models;
using System;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Program
    {
        public static string ConnectionString = "<your connection string>";

        static void Main(string[] args)
        {
            SenderHelper helper = new SenderHelper(ConnectionString);
            
            for(int i = 0; i < 5; i++)
            {
                helper.DataSender();
            }
        }
    }
}
