using SimpleExample_For_Teaching.Contract;

namespace SimpleExample_For_Teaching.Services
{
    public class WeatherStation : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _weatherData;
        public string WeatherData
        {
            get => _weatherData;
            set
            {
                _weatherData = value;
                Notify(); // به‌محض تغییر، اطلاع‌رسانی می‌کنه
            }
        }
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
           _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_weatherData);
            }
        }
    }
}
