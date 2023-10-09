namespace DesignPatterns.Factory;

public class SourdoughPizzaStore : PizzaStore
{
    public override IPizza CreatePizza(IEnumerable<string> ingredients) => new SourdoughPizza(ingredients);
}