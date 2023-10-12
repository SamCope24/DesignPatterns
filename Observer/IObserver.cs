namespace DesignPatterns.Observer;

public interface IObserver
{
    // Receive update from Subject
    void Update(ISubject subject);
}