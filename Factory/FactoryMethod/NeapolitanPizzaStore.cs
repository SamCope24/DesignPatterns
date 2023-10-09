namespace DesignPatterns.Factory;

public class NeapolitanPizzaStore : PizzaStore
{
    public override IPizza CreatePizza(IEnumerable<string> ingredients) => new NeapolitanPizza(ingredients);

}