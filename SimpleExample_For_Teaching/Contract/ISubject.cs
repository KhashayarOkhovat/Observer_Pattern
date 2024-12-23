namespace SimpleExample_For_Teaching.Contract
{
    public interface ISubject
    {
        void Attach(IObserver observer); // اضافه کردن مشاهده کننده
        void Detach(IObserver observer); // حذف مشاهده کننده
        void Notify(); // اطلاع رسانی به مشاهده کننده
    }
}
