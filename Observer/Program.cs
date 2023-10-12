using DesignPatterns.Observer;

var subject = new Subject();

IObserver observer = new Observer();
IObserver over50 = new Over50Observer();
IObserver under50 = new Under50Observer();

subject.Attach(observer);
subject.Attach(over50);
subject.Attach(under50);

for (int i = 0; i < 10; i++)
{
    subject.SomeBusinessLogic();
    Console.WriteLine();
}