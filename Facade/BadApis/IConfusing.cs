namespace DesignPatterns.Facade.BadApis;

public interface IConfusing
{
    int Execute(int a, int b, int c);
    int Method1();
    int Method2();
    int Method2(int x, int y);
}