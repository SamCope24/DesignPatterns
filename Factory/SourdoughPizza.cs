namespace DesignPatterns.Factory;

public class SourdoughPizza : IPizza
{
    private readonly List<string> _ingredients;
    public SourdoughPizza(IEnumerable<string> ingredients) => _ingredients = ingredients.ToList();
    public DoughType DoughType => DoughType.DetroitStyle;
    public IEnumerable<string> Ingredients => _ingredients;
}