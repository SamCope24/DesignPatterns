using DesignPatterns.Iterator;
using System.Diagnostics;

var stopwatch = new Stopwatch();
stopwatch.Start();

var evens = Iterator.ReturnEvenNumbers(1000000000);
//var evens = Iterator.YieldReturnEvenNumbers(1000000000);

stopwatch.Stop();
Console.WriteLine($"Time taken to start enumerating evens: {stopwatch.ElapsedMilliseconds}ms");

foreach (int number in evens)
{
    //Console.WriteLine(number);
}

System.Console.WriteLine("I'm Done");

