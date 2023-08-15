namespace DesignPatterns.Decorator;

public class Latte : ICoffee
{
    public List<string> GetIngredients() =>
        new() { "Water", "Coffee", "Milk" };

    public decimal GetPrice() =>
        2.80M;
}