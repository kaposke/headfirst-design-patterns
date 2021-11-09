namespace weather
{
    public class CurrentConditionsDisplay : IDisplayElement, IObserver
    {
        private float _temperature;
        private float _humidity;
        private WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }
        
        public void Display()
        {
            System.Console.WriteLine($"Temperature: {_temperature} | Humidity: {_humidity}");
        }

        public void Update()
        {
            _temperature = _weatherData.Temperature;
            _humidity = _weatherData.Humidity;
            Display();
        }
    }
}