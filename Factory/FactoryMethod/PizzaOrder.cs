namespace DesignPatterns.Factory;

public class PizzaOrder
{
    private readonly List<string> _toppings;

    public PizzaOrder(string customerName, DoughType doughType, IEnumerable<string> toppings)
    {
        (customerName, doughType) = (CustomerName, DoughType);
        _toppings = toppings?.ToList() ?? throw new ArgumentNullException(nameof(toppings));
    }


    public string CustomerName { get; } = string.Empty;
    public DoughType DoughType { get; }
    public IEnumerable<string> Toppings => _toppings;
}