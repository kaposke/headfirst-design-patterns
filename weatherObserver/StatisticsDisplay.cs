namespace weather
{
    public class StatisticsDisplay : IDisplayElement, IObserver
    {
        private int updateCount;
        private float _temperatureAvg;
        private float _humidityAvg;
        private float _pressureAvg;
        private WeatherData _weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            System.Console.WriteLine($"Temperature average: {_temperatureAvg}");
            System.Console.WriteLine($"Humidity average: {_humidityAvg}");
            System.Console.WriteLine($"Pressure average: {_pressureAvg}");
        }

        public void Update()
        {
            float temperature = _weatherData.Temperature;
            float humidity = _weatherData.Humidity;
            float pressure = _weatherData.Pressure;
            
            _temperatureAvg = (_temperatureAvg * updateCount + temperature) / (updateCount + 1);
            _humidityAvg = (_humidityAvg * updateCount + humidity) / (updateCount + 1);
            _pressureAvg = (_pressureAvg * updateCount + pressure) / (updateCount + 1);
            updateCount++;
            Display();
        }
    }
}