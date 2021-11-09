using System.Collections.Generic;

namespace weather
{
    public class WeatherData : ISubject
    {
        List<IObserver> observers;
        public float Temperature { get; private set; }
        public float Humidity { get; private set; }
        public float Pressure { get; private set; }

        public WeatherData()
        {
            observers = new List<IObserver>();
        }
        
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }
    }
}