namespace DesignPatterns.Observer;

public class Observer : IObserver
{
    public void Update(ISubject subject)
    {
        if (subject is Subject s)
        {
            Console.WriteLine($"Observer: I know your state is: {s.State}");
        }
    }
}