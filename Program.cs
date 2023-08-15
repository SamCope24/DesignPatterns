using DesignPatterns.Decorator;

ICoffee americano = new Americano();
ICoffee latte = new Latte();
ICoffee americanoWithExtraShot = new ExtraShot(americano);
ICoffee latteWithExtraShot = new ExtraShot(latte);

Console.WriteLine($"Americano - Price: {americano.GetPrice()}");
foreach (var ingredient in americano.GetIngredients())
{
    Console.WriteLine(ingredient);
}

Console.WriteLine();

Console.WriteLine($"Latte - Price: {latte.GetPrice()}");
foreach (var ingredient in latte.GetIngredients())
{
    Console.WriteLine(ingredient);
}

Console.WriteLine();

Console.WriteLine($"Americano with Extra Shot - Price: {americanoWithExtraShot.GetPrice()}");
foreach (var ingredient in americanoWithExtraShot.GetIngredients())
{
    Console.WriteLine(ingredient);
}

Console.WriteLine();

Console.WriteLine($"Latte with Extra Shot - Price: {latteWithExtraShot.GetPrice()}");
foreach (var ingredient in latteWithExtraShot.GetIngredients())
{
    Console.WriteLine(ingredient);
}
