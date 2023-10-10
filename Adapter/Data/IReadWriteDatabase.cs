namespace DesignPatterns.Adapter.Data;

public interface IReadWriteDatabase<out TDatabase> where TDatabase : notnull, Database
{
    TDatabase Db { get; }
}