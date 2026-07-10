
using System.ComponentModel;
using System.Reflection;
class Person
{    
    public readonly string name ;

 public  Person(string name)
{
    this.name = name;
}
    
}
class ConsoleApp
{
    public static void Main(string[] args)
    {
        Person p1 = new Person("Joy Ghosh Sourjo");
        // p1.name = "Joy Ghosh Sourjo";    
        System.Console.WriteLine(p1.name);
    }
}