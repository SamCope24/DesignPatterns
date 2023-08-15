namespace DesignPatterns.Decorator;

public class Americano : ICoffee
{
    public List<string> GetIngredients() =>
        new() { "Water", "Coffee" };

    public decimal GetPrice()
        => 2.50M;
}