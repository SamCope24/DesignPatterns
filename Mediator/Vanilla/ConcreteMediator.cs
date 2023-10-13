using System;

namespace DesignPatterns.Mediator.Vanilla;

public class ConcreteMediator : IMediator
{
    private readonly Component1 _component1;
    private readonly Component2 _component2;

    public ConcreteMediator(Component1 component1, Component2 component2)
    {
        _component1 = component1 ?? throw new ArgumentNullException(nameof(component1));
        _component2 = component2 ?? throw new ArgumentNullException(nameof(component2));
        _component1.SetMediator(this);
        _component2.SetMediator(this);
    }

    public void Notify(object sender, string ev)
    {
        if (ev == "A")
        {
            Console.WriteLine("Mediator reacts to event A");
            _component2.DoC();
        }
        if (ev == "D")
        {
            Console.WriteLine("Mediator reacts to event D");
            _component1.DoB();
            _component2.DoC();
        }
    }
}