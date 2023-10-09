namespace DesignPatterns.Factory;

public class DetroitStylePizza : IPizza
{
    private readonly List<string> _ingredients;
    public DetroitStylePizza(IEnumerable<string> ingredients) => _ingredients = ingredients.ToList();
    public DoughType DoughType => DoughType.DetroitStyle;
    public IEnumerable<string> Ingredients => _ingredients;
}