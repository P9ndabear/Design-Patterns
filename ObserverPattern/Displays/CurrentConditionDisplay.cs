using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class CurrentConditionDisplay : WeatherDisplay
    {
        private Subject weatherData;
        public CurrentConditionDisplay(Subject weatherData) : base(weatherData)
        { 
            // Set the field and register itself with the weatherdata subject
        }

        public override void Display()
        {
            Console.WriteLine($"Current conditions: {temperature}F degrees, {humidity}% humidity and {pressure} pressure");
            // Print the current conditions of the weather
        }
    }
}
