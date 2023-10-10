namespace DesignPatterns.Facade;

public interface IBetterApi
{
    int AddTwoNumbers(int first, int second);
    int AddThenMultiply(int first, int second, int factor);
    int AddThenMultiply(int first, int second, int third, int factor);
}