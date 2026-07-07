
using System.ComponentModel;

class ConsoleApp
{
    public static void Main(string[] args)
    {
        while (true)
        {
            System.Console.WriteLine("Enter a Number to get square");
            System.Console.WriteLine("Type 'quit' to exit Or type help");
            System.Console.WriteLine("====================");
            string input = Console.ReadLine() ?? "";
            // input = input.ToLower();
            if(input.ToLower().Trim() == "quit")
            {
                System.Console.WriteLine("Goodbye");
                break;
            } else if(input.ToLower().Trim() == "help")
            {
                System.Console.WriteLine("Instructions: Please enter a whole number from 1 to 10. The program will calculate and display its square value. Type 'quit' at any time to close the application.");
                System.Console.WriteLine();
                continue;
            }
            if(int.TryParse(input, out int Number))
            {
                int square = Number * Number;
                System.Console.WriteLine($"The square of {Number} is {square}");                
            } else
            {
                System.Console.WriteLine("Invalid input. Please enter a valid number, 'help', or 'quit'.");
            }
            System.Console.WriteLine();
        }
    }

}
