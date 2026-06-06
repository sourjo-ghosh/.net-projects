using System;
using System.Globalization;

class ConsoleApp
{
    public static void Main(string[] args)
    {
        // ------ simple Console app -----------
        // Console.WriteLine("My name is Joy Ghosh Sourjo");
        // Console.WriteLine("I am 19 years old");
        // Console.WriteLine("I am .NET and react developer or a fullstack developer");
        // Console.Write("My name is Joy Ghosh Sourjo");
        // Console.Write(" I am 19 years old, ");
        // Console.Write("I am a .NET developer");


        // --------------- Variables and data types ----------
        /*
         * there are 6 types of data
         * 1. string
         * 4. int
         * 3. boolean
         * 5. double
         * 6. float
         * 2. char
         */

        /*
        string fullName = "Joy Ghosh Sourjo";
        Console.WriteLine(fullName);
        int age = 20;
        Console.WriteLine(age);
        bool isStudent = true;
        Console.WriteLine(isStudent);
        char bloodGroup = 'B';
        Console.WriteLine(bloodGroup);
        double gpa = 4.00;
        Console.WriteLine(gpa);
        */

        // const and var
        /*
        const int age = 19;
        Console.WriteLine(age);
        // when we need to store a immutable data then we will use const
        var double price = 3.994;
        Console.WriteLine(price);
        // when we need to store a mutable data then we will use var
        */

        // // type casting
        // int salary = 2322;
        // Console.WriteLine(salary);
        // double salary2 = salary;
        // Console.WriteLine(salary2);
        
        
        // implicit type conversion / automatic type conversion
        // int => double => long => float etc.
        // explicit type conversion / manual type conversion
        // int num1 = 10;
        // double num2 = num1;
        // double num3 = 409.555;
        // int num4 = Convert.ToInt32(num3);
        // double num5 = 43.333333;
        // string number = "200.6";
        // double num6 = double.Parse(number);
        // bool isSuccess = int.TryParse(number, out int result);
        // if (isSuccess)
        // {
        //     Console.WriteLine("Perfectly data converted");
        // }
        // else
        // {
        //     Console.WriteLine("Not data converted");
        //     
        // }
        //
        // Console.WriteLine($"result = {result}");
        // Console.WriteLine($"isSuccess = {isSuccess}");
        // Console.Write("Enter your name : ");
        // string? name = Console.ReadLine();
        // Console.Write("Enter your age : ");
        // string? ageInput = Console.ReadLine();
        // bool isValidAge = int.TryParse(ageInput, out int age);
        // if (!isValidAge)
        // {
        //     Console.WriteLine("Enter a valid age ");
        //     return;
        // }
        // else
        // {
        //     Console.WriteLine($"Hi, {name} Your are {age} years old");
        // }
        // Console.WriteLine(name);
        // Console.WriteLine(age);
        // Console.WriteLine(age.GetType());
        // Console.WriteLine(name?.GetType());



        // C# does not have a single, official total number of operators because they can be categorized by functionality or by the number of operands they take. However, the language includes over 40 distinct operator symbols grouped into roughly 10 functional categories.
        // there are three types of operators 
        // 1. unary 
        // 2. binary 
        // 3. ternary 
        // int a = 3;
        // a++;
        // a--;
        // these are unary operators, Take exactly one operand.


        // int num1 = 10;
        // int num2 = 3;
        // Console.WriteLine(num1 + num2);
        // Console.WriteLine(num1 - num2);
        // Console.WriteLine(num1 * num2);
        // Console.WriteLine(num1 / num2);
        // Console.WriteLine(num1 % num2);
        // Console.WriteLine("Create a sum and avg of a 3 numbers");
        //
        // Console.Write("Enter first Number: ");
        // string? inp1 = Console.ReadLine();
        // Console.Write("Enter second Number: ");
        // string? inp2 = Console.ReadLine();
        // Console.Write("Enter third Number: ");
        // string? inp3 = Console.ReadLine();
        //
        // bool IsInp1Valid = double.TryParse(inp1, out double num1);
        // bool IsInp2Valid = double.TryParse(inp2, out double num2);
        // bool IsInp3Valid = double.TryParse(inp3, out double num3);
        // if (IsInp1Valid && IsInp2Valid && IsInp3Valid)
        // {
        //     double sum = num1 + num2 + num3;
        //     double avg = (num1 + num2 + num3) / 3.0;
        //     Console.WriteLine("The sum of the numbers is: " + sum);
        //     Console.WriteLine("The avg of the numbers is: " + avg);
        // }
        // else
        // {
        //     Console.WriteLine("Entered one or more number is valid");
        // }

        double fahrenheit;
        
        Console.Write("Enter fahrenheit in Celsius: ");

        fahrenheit = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine(fahrenheit);
        
        double celsius = (fahrenheit - 32) / 1.8;
        Console.WriteLine($"celsius = {celsius:F2} degrees");

        double c, f;
        Console.Write("Enter celsius to fahrenheit: ");
        c = Convert.ToDouble(Console.ReadLine());
        f = (c * 1.8) + 32;
        Console.WriteLine($"fahrenheit = {f:F2} degrees");
        
        
        Console.ReadLine();
    }
}
