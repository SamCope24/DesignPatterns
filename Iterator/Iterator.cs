namespace DesignPatterns.Iterator;

public static class Iterator
{
    public static IEnumerable<int> ReturnEvenNumbers(int endingNumber)
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

    public static IEnumerable<int> YieldReturnEvenNumbers(int endingNumber)
    {
        for (int i = 1; i <= endingNumber; i++)
        {
            if (IsEven(i))
            {
                yield return i;

                if (i == 10000)
                {
                    Console.WriteLine("Nope, you've had enough evens for today sunshine!");
                    yield break;
                }
            }
        }
    }
}