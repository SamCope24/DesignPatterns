namespace DesignPatterns.Factory;

public class DetroitStylePizzaFactory : PizzaFactory
{
    public override IPizza CreatePizza(IEnumerable<string> ingredients) => new DetroitStylePizza(ingredients);
}