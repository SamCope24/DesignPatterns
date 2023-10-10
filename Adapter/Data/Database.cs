namespace DesignPatterns.Adapter.Data;

public class Database : IDisposable
{
    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}