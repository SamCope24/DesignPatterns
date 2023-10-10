using DesignPatterns.Facade.BadApis;

namespace DesignPatterns.Facade;

public class Facade : IBetterApi
{
    private readonly IConfusing _confusingApi;
    private readonly IOverdone _overdoneApi;

    public Facade(IConfusing confusingApi, IOverdone overdoneApi)
    {
        _confusingApi = confusingApi ?? throw new ArgumentNullException(nameof(confusingApi));
        _overdoneApi = overdoneApi ?? throw new ArgumentNullException(nameof(overdoneApi));
    }

    public int AddThenMultiply(int first, int second, int factor) =>
        _confusingApi.Execute(first, second, factor);

    public int AddThenMultiply(int first, int second, int third, int factor) =>
        _overdoneApi.DoSomethingElse(first, second, third);

    public int AddTwoNumbers(int first, int second) =>
        _confusingApi.Method2(first, second);

}