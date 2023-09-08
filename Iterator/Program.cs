using DesignPatterns.Iterator;
using System.Diagnostics;
using System.Collections.Generic;

var iterator = new Iterator();

var stopwatch = new Stopwatch();
stopwatch.Start();

//var evens = iterator.ReturnEvenNumbers(1000000000);
var evens = iterator.YieldReturnEvenNumbers(1000000000);

stopwatch.Stop();
Console.WriteLine($"Time taken to start enumerating evens: {stopwatch.ElapsedMilliseconds}ms");

foreach (int number in evens)
{
    //Console.WriteLine(number);
}


