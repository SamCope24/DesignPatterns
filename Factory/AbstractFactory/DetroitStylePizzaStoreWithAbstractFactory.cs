namespace DesignPatterns.Factory;

public class DetroitStylePizzaStoreWithAbstractFactory : PizzaStoreWithAbstractFactory
{
    public DetroitStylePizzaStoreWithAbstractFactory() : this(new DetroitStylePizzaFactory())
    {
    }
    public DetroitStylePizzaStoreWithAbstractFactory(IPizzaFactory factory) : base(factory)
    {
    }
}