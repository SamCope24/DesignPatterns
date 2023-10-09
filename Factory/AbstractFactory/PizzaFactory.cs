namespace DesignPatterns.Factory;

public abstract class PizzaFactory : IPizzaFactory
{
    public abstract IPizza CreatePizza(IEnumerable<string> ingredients);
}