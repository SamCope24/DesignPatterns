namespace DesignPatterns.Factory;

public class NeapolitanPizza : IPizza
{
    private readonly List<string> _ingredients;
    public NeapolitanPizza(IEnumerable<string> ingredients) => _ingredients = ingredients.ToList();
    public DoughType DoughType => DoughType.Neapolitan;
    public IEnumerable<string> Ingredients => _ingredients;
}