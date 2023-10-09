namespace DesignPatterns.Factory
{
    public abstract class PizzaStoreWithAbstractFactory
    {
        private readonly IPizzaFactory _factory;
        public PizzaStoreWithAbstractFactory(IPizzaFactory factory) =>
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

        public IPizza OrderPizza(PizzaOrder order)
        {
            IPizza pizza = _factory.CreatePizza(order.Toppings);
            return pizza;
        }
    }
}