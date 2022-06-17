// See https://aka.ms/new-console-template for more information
using Tests;

Class1 c1 = new Class1();
string recipie = "Padding";

Console.WriteLine("Before");
c1.listSteps(recipie).ForEach(x => Console.WriteLine(x));

c1.test(recipie, 0, "Something something", "img.png");

Console.WriteLine("After");
c1.listSteps(recipie).ForEach(x => Console.WriteLine(x));

// Console.WriteLine("Hello, World!");
