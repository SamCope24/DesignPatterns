namespace DesignPatterns.Adapter.Data;

public class Command<TDatabase> where TDatabase : notnull, Database
{
    private readonly IReadWriteDatabase<TDatabase> _database;

    public Command(IReadWriteDatabase<TDatabase> database)
    {
        _database = database ?? throw new ArgumentNullException(nameof(database));
    }
}