Console.WriteLine("Input first number!");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Input second number!");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Input third number!");
double c = double.Parse(Console.ReadLine());

double max = a;
if (b > max)
{
    max = b;
}
if (c > max) 
{
    max = c;
}

Console.WriteLine("Maximum is " + max);