using System.Collections.Generic;

namespace DesignPatterns.Factory;

public interface IPizza
{
    DoughType DoughType { get; }
    IEnumerable<string> Ingredients { get; }
}