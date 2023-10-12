namespace DesignPatterns.Observer;

public interface ISubject
{
    // Attach an Observer
    void Attach(IObserver observer);
    
    // Detach an Observer
    void Detach(IObserver observer);
    
    // Notify all observers about an event
    void Notify();
}