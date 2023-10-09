namespace DesignPatterns.Factory;

public class SimplePizzaFactory
{
    public static IPizza CreatePizza(DoughType doughType, IEnumerable<string> ingredients) => doughType switch
    {
        DoughType.Neapolitan => new NeapolitanPizza(ingredients),
        DoughType.Sourdough => new SourdoughPizza(ingredients),
        DoughType.DetroitStyle => new DetroitStylePizza(ingredients),
        _ => throw new ArgumentException("Invalid Pizza Type")
    };
}