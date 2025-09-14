namespace simple_calculator;

/*
 * This calculator only accepts two numbers and runs once.
 * Improve: Run program until user quits.
 * Improve: User may continue to append operators and operands
 * End game funciton not working.
 */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Simple Calculator! Currently only accepting two numbers per calculation");
        Console.WriteLine("To quit, press 'q' when selecting operator.");

        Console.Write("Choose an operator: +, -, *, /: ");
        string operation = Console.ReadLine();

        Console.Write("Enter first number: ");
        //decimal firstNumber = decimal.Parse(Console.ReadLine());
        decimal total = decimal.Parse(Console.ReadLine());
        
        Console.Write("Enter next number: ");
        //decimal secondNumber = decimal.Parse(Console.ReadLine());
        decimal nextNumber = decimal.Parse(Console.ReadLine());
        
        decimal result = 0;
        
        bool running = true;

        while (running)
        {
            switch (operation)
            {
                case "+":
                    result = total + nextNumber;
                    break;
                case "-":
                    result = total - nextNumber;
                    break;
                case "*":
                    result = total * nextNumber;
                    break;
                case "/":
                    //remember to truncate result
                    result = (decimal)total / nextNumber;
                    break;
                case "q":
                    running = false;
                    break;
                default:
                    Console.WriteLine("<( •̀ᴖ•́)>");
                    break;
            }
            
            Console.WriteLine();
            Console.WriteLine($"{total} {operation} {nextNumber} = {result}");

            total = result;

            Console.Write("Enter next operator: ");
            operation = Console.ReadLine();

            if (operation != "q")
            {
                Console.Write("Enter next number: ");
                nextNumber = decimal.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }
        Console.WriteLine("Calculator Shutting down...");
    }
}
    