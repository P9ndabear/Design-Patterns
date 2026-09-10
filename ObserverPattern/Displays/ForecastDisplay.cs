using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : WeatherDisplay
    {
      

        private Subject weatherData;
        public ForecastDisplay(Subject weatherData) : base(weatherData)
        { 
            // Set the field and register itself with the weatherdata subject
        }

        public override void Display()
        {
            if (temperature < 250 && humidity < 50)
            {
                Console.WriteLine("Forecast: It's going to be a cold and humid day!");
            }
            else if (temperature > 750  && humidity > 100)
            {
                Console.WriteLine("Forecast: It's going to be a hot and dry day!");
            }
            else
            {
                Console.WriteLine("Forecast: The weather is expected to be moderate.");
            }

            // Print a forecast message based on the current temperature and humidity
        }
    }
}
