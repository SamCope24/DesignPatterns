namespace DesignPatterns.Facade.BadApis;

public class Confusing : IConfusing
{
    public int Execute(int a, int b, int c)
    {
        throw new NotImplementedException();
    }

    public int Method1()
    {
        throw new NotImplementedException();
    }

    public int Method2()
    {
        throw new NotImplementedException();
    }

    public int Method2(int x, int y)
    {
        throw new NotImplementedException();
    }
}
