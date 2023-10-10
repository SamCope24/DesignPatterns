namespace DesignPatterns.Adapter.Data;

public interface IReadOnlyDatabase<out TDatabase> where TDatabase : notnull, Database
{
    TDatabase Db { get; }
}