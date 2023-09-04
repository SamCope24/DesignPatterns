using System;

namespace DesignPatterns.Adapter;

public class Database : IDisposable
{
    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}