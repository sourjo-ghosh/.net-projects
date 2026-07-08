
using System.ComponentModel;
class Person
{
    public string name;
    public int age;
    public double height;
    public int weight;
    // public void SetData(string name, int age, double height, int weight)
    // {
    //     this.name = name;
    //     this.age = age;
    //     this.height = height;
    //     this.weight = weight;
    // }
    public void Display()
    {
        System.Console.WriteLine($"Name : {name}");
        System.Console.WriteLine($"Age : {age}");
        System.Console.WriteLine($"Height : {height}");
        System.Console.WriteLine($"Weight : {weight}");
        System.Console.WriteLine("--------------------------------------------------");
    }
    public Person(string name, int age, double height, int weight)
    {
        // parameterized constructor
        this.name = name;
        this.age = age;
        this.height = height;
        this.weight = weight;
    }
    public Person()
    {
        // default constructor
        name = "Unknown";
        age = 0;
        height = 0.0;
        weight = 0;
    }
}

class ConsoleApp
{
    public static void Main(string[] args)
    {
        Person p1 = new Person("Joy Ghosh", 19, 5.9, 58);
        // p1.SetData("Joy Ghosh", 19, 5.9, 58);
        // p1.name = "Joy Ghosh";
        // p1.age = 19;
        // p1.height = 5.9;
        // p1.weight = 58;

        Person p2 = new Person("Ajoy Ghosh", 14, 5.0, 60);
        // p2.SetData("Ajoy Ghosh", 14, 5.0, 60);

        Person p3 = new Person("Ajoy Ghosh srijon", 14, 5.0, 60);
        // p3.SetData("Ajoy Ghosh srijon", 14, 5.0, 60);
        // p3.age = 14;
        // p3.height = 5.0;
        // p3.weight = 60;

        Person p4 = new Person();
        // p4.SetData("Purnima rani ghosh", 16, 5.5, 55);
        // p4.name = "Purnima rani ghosh";
        // p4.age = 16;
        // p4.height = 5.5;
        // p4.weight = 55;
        p1.Display();
        p2.Display();
        p3.Display();
        p4.Display();

    }
}
