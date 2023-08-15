namespace DesignPatterns.Decorator;

public class ExtraShot : ICoffee
{
    private readonly ICoffee _coffee;

    public ExtraShot(ICoffee coffee) =>
        _coffee = coffee ?? throw new ArgumentNullException(nameof(coffee));

    public List<string> GetIngredients()
    {
        var ingredients = _coffee.GetIngredients();
        ingredients.Add("Shot of Espresso");
        return ingredients;
    }

    public decimal GetPrice() =>
        _coffee.GetPrice() + 1.0M;
}