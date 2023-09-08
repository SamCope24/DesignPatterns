using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Iterator;

public class Iterator
{
    public IEnumerable<int> ReturnEvenNumbers(int endingNumber)
    {
        var evens = new List<int>();

        for (int i = 1; i <= endingNumber; i++)
        {
            if (IsEven(i))
            {
                evens.Add(i);
            }
        }

        return evens;
    }

    private static bool IsEven(int number) => number % 2 == 0;

    public IEnumerable<int> YieldReturnEvenNumbers(int endingNumber)
    {
        for (int i = 1; i <= endingNumber; i++)
        {
            if (IsEven(i))
            {
                yield return i;
            }
        }
    }
}