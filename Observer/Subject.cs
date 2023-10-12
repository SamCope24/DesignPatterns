namespace DesignPatterns.Observer;

public class Subject : ISubject
{
    private readonly List<IObserver> _observers = new();
    private readonly Random _random = new();

    public int State { get; private set; } = 0;

    public void Attach(IObserver observer) => _observers.Add(observer);
    public void Detach(IObserver observer) => _observers.Remove(observer);
    public void Notify() => _observers.ForEach(x => x.Update(this));
    public void SomeBusinessLogic()
    {
        State = _random.Next(100);
        Console.WriteLine($"Subject: My state is: {State}!");
        Notify();
    }
}