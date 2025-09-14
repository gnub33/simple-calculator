namespace simple_calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Simple Calculator! Currently only accepting two numbers per calculation");

        Console.WriteLine("Choose an operator: +, -, *, /");
        string op = Console.ReadLine();

        Console.WriteLine("Enter first number: ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        decimal result = 0;
        Console.WriteLine();
        Console.WriteLine($"{firstNumber} {op} {secondNumber} = {result}");
    }
}
    