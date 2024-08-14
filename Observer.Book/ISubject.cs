namespace Observer.Book
{
    public interface ISubject
    {

        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();

    }
}
