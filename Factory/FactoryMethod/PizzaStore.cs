namespace DesignPatterns.Factory;

public abstract class PizzaStore : ICreatePizza
{
    public IPizza OrderPizza(PizzaOrder order)
    {
        IPizza pizza = CreatePizza(order.Toppings);
        return pizza;
    }
    public abstract IPizza CreatePizza(IEnumerable<string> toppings);
}