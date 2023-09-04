namespace DesignPatterns.Adapter;

public interface IReadOnlyDatabase<out TDatabase> where TDatabase : notnull, Database
{
    TDatabase Db { get; }
}