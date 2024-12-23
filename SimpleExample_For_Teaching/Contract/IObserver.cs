namespace SimpleExample_For_Teaching.Contract
{
    public interface IObserver
    {
        void Update(string weatherData); ///هر کسی (مشاهده کننده) که بخواهد از تغییر وضعیت با خبر بشه باید این متد رو پیاده سازی کند 
    }
}
