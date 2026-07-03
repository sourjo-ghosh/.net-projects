using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

class ConsoleApp
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Temperature converter");

        System.Console.WriteLine("Choose 1 to celsius to fahrenheit");
        System.Console.WriteLine("Choose 2 to fahrenheit to celsius");
        int choice = Convert.ToInt32(Console.ReadLine());
        bool isInvalid = choice >= 1 && choice <= 2;
        if (!isInvalid)
        {
           System.Console.WriteLine("Invalid number");
           return; 
        }
        switch(choice)
        {
            case 1:
            double inputCel = Convert.ToDouble(Console.ReadLine());
            double resultCel = (inputCel * 1.8) + 32;
            System.Console.WriteLine($"{resultCel}F"); 
            break;


            case 2:
            double inputFah = Convert.ToDouble(Console.ReadLine());
            double resultFah = (inputFah - 32) * (5.0 / 9.0);
            System.Console.WriteLine($"{resultFah}C"); 
            break;
            default:
            System.Console.WriteLine("Invalid");
            break;
        };
    }

}
