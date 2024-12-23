using SimpleExample_For_Teaching.Contract;

namespace SimpleExample_For_Teaching.Services
{
    public class Farmer : IObserver
    {
        public void Update(string weatherData)
        {
            Console.WriteLine($"Farmer: Got the weather update! Weather is now {weatherData}");
        }
    }
}
