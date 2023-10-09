namespace DesignPatterns.Factory;

public class DetroitStylePizzaStore : PizzaStore
{
    public override IPizza CreatePizza(IEnumerable<string> ingredients) => new DetroitStylePizza(ingredients);
}