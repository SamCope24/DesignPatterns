namespace DesignPatterns.Adapter;

public interface IReadWriteDatabase<out TDatabase> where TDatabase : notnull, Database
{
    TDatabase Db { get; }
}