using ObserverPattern.Displays;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            // Create instances of displays 
            new CurrentConditionDisplay(weatherData);
            new ForecastDisplay(weatherData);
            new StatisticsDisplay(weatherData);

            weatherData.SetMeasurements(100, 25, 30.4f);
            weatherData.SetMeasurements(500, 75, 29.2f);
            weatherData.SetMeasurements(1000, 100, 29.2f);
        }
    }
}