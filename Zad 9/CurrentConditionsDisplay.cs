using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    internal class CurrentConditionsDisplay : IObserver
    {
        private float temperature;
        private float humidity;
        private ISubject weatherStation;

        public CurrentConditionsDisplay(ISubject weatherStation)
        {
            this.weatherStation = weatherStation;
            weatherStation.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature}C degrees and {humidity}% humidity");
        }
    }
}
