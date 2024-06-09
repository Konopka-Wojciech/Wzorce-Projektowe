namespace Weather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherStation);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherStation);

            weatherStation.SetMeasurements(30, 65, 30.4f);
            weatherStation.SetMeasurements(25, 70, 29.2f);
            weatherStation.SetMeasurements(20, 90, 29.2f);
        }
    }
}
