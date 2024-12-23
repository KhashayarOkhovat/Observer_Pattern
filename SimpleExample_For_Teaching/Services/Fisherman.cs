using SimpleExample_For_Teaching.Contract;

namespace SimpleExample_For_Teaching.Services
{
    public class Fisherman : IObserver
    {
        public void Update(string weatherData)
        {
            Console.WriteLine($"Fisherman: Got the weather update! Weather is now {weatherData}");
        }
    }
}
