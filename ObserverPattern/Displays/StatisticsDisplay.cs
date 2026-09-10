using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : WeatherDisplay
    {
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;
        private Subject weatherData;
        public StatisticsDisplay(Subject weatherData) : base(weatherData)
        { 
            // Set the field and register itself with the weatherdata subject
        }

        public override void Update(float temperature, float humidity, float pressure)
        {
            sumTemperature += temperature;
            countUpdated++;

            if (temperature > maxTemp || countUpdated == 1)
            {
                maxTemp = temperature;
            }

            if (temperature < minTemp || countUpdated == 1)
            {
                minTemp = temperature;
            }
            Display();  
        }

        public override void Display()
        {
            Console.WriteLine($"Statistics Display: Average/Max/Min temperature = {sumTemperature / countUpdated}/{maxTemp}/{minTemp}");
            // Print the average, maximum and minimum temperature. Use appropriate fields
        }
    }
}
