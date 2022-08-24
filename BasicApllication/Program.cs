using MathsLib;

Console.WriteLine("Hello, World!");
int a = 0;
int b = 0;
int c = 0;
Console.WriteLine("enter value for a");
a = int.Parse(Console.ReadLine());

Console.WriteLine("enter value for b");
b = int.Parse(Console.ReadLine());
 
Basic basic = new Basic();
c = basic.Add(a, b);

Console.WriteLine($"Result of adding two numbers {0} + {1} = {2}", a,b,c);
