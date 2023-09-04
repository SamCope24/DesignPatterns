namespace DesignPatterns.Adapter;

public class Query<TDatabase> where TDatabase : notnull, Database
{
    private readonly IReadOnlyDatabase<TDatabase> _database;

    public Query(IReadOnlyDatabase<TDatabase> database)
    {
        _database = database ?? throw new ArgumentNullException(nameof(database));
    }
}