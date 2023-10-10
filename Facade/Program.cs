using DesignPatterns.Facade;
using DesignPatterns.Facade.BadApis;

IConfusing confusingApi = new Confusing();
IOverdone overdoneApi = new Overdone();

confusingApi.Execute(1, 2, 3);
overdoneApi.DoSomethingElse(1, 2 ,3);
confusingApi.Method2(1, 2);

var facade = new Facade(confusingApi, overdoneApi);

facade.AddTwoNumbers(first: 1, second: 2);
facade.AddThenMultiply(first: 1, second: 2, factor: 3);
facade.AddThenMultiply(first: 1, second: 2, third: 3, factor: 4);