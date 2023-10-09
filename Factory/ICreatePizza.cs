namespace DesignPatterns.Factory;

public interface ICreatePizza
{
    public IPizza CreatePizza(IEnumerable<string> ingredients);
}