namespace DesignPatterns.Adapter.Data;

public class DatabaseAccessAdapter<TDatabase> :
    IReadOnlyDatabase<TDatabase>, IReadWriteDatabase<TDatabase>, IDisposable
    where TDatabase : notnull, Database
{
    public DatabaseAccessAdapter(TDatabase database)
    {
        Db = database;
    }

    public TDatabase Db { get; }

    public void Dispose()
    {
        Db.Dispose();
        GC.SuppressFinalize(this);
    }
}