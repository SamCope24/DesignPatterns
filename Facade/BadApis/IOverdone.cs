namespace DesignPatterns.Facade.BadApis;

public interface IOverdone
{
    int DoSomething(int x, int y);
    int DoSomethingElse(int x, int y, int z);
    int DoSomethingAgain(int x, int y, int z, int a);
}