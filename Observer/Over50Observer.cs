namespace DesignPatterns.Observer;

public class Over50Observer : IObserver
{
    public void Update(ISubject subject)
    {
        if (subject is Subject {State: > 50} s)
        {
            System.Console.WriteLine($"Over 50 Observer: I know your state is: {s.State}");
        }
    }
}