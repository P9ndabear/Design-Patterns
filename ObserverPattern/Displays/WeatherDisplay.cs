using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal abstract class WeatherDisplay : Observer, DisplayElement
    {
        protected float temperature;
        protected float humidity;
        protected float pressure;
        private Subject weatherData;
        public WeatherDisplay(Subject weatherData) 
        { 
            weatherData.RegisterObserver(this);
            // Set the field and register itself with the weatherdata subject
        }
        public void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }

        public abstract void Display();
    }
}
