using System;

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

        Console.Write("Enter your name : ");
        string? name = Console.ReadLine();
        Console.Write("Enter your age : ");
        string? ageInput = Console.ReadLine();
        bool isValidAge = int.TryParse(ageInput, out int age);
        if (!isValidAge)
        {
            Console.WriteLine("Enter a valid age ");
            return;
        }
        else
        {
            Console.WriteLine($"Hi, {name} Your are {age} years old");
        }
        // Console.WriteLine(name);
        // Console.WriteLine(age);
        // Console.WriteLine(age.GetType());
        // Console.WriteLine(name?.GetType());
        
        Console.ReadLine();
    }
}
