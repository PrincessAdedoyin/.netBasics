// See https://aka.ms/new-console-template for more information


//C# is strongly typed

// Variables
using System.Diagnostics.Contracts;
using basics;

int number1 = 2;
int number2 = 3;

var ans = number2 * number1;

Console.WriteLine(ans);

static int Multiply(int a, int b)
{
    return a * b;
}


Console.WriteLine("Welcome to our multiply method");
Console.WriteLine("Please enter the first digit");
var value = Console.ReadLine();
int a = Convert.ToInt32(value);

Console.ReadKey();

Console.WriteLine("Please enter the second digit");

int b = int.Parse(Console.ReadLine());


var thisGuy = new Arithmetics(a, b);
Console.WriteLine($"Result: {a} * {b} = {thisGuy.Multiply()}");




