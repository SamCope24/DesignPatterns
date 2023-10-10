namespace DesignPatterns.Facade.BadApis;

public class Overdone : IOverdone
{
    public int DoSomething(int x, int y)
    {
        throw new NotImplementedException();
    }

    public int DoSomethingAgain(int x, int y, int z, int a)
    {
        throw new NotImplementedException();
    }

    public int DoSomethingElse(int x, int y, int z)
    {
        throw new NotImplementedException();
    }
}
