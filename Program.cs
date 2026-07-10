public class StudentManagement
{
    private string? _name;   
    private DateTime? _birthDate;   
    private string? _rollNumber;   

    public string? Name 
    { 
        get{return _name;} 
        set{_name = value;} 
    }
    public DateTime? BirthDate 
    { 
        get{return _birthDate;} 
        set{if(value > DateTime.Now)
            {
                throw new ArgumentException("Date of Birth can not be in the future");
            }
            _birthDate = value;
        } 
    }
    public string? RollNumber 
    { 
        get{return _rollNumber;} 
        set{_rollNumber = value;} 
    }

    public StudentManagement(string? name, DateTime? birthDate, string? rollNumber)
    {
        Name = name;
        BirthDate = birthDate;
        RollNumber = rollNumber;
    }
}
class Project

{
    static void Main(string[] args)
    {
        Console.WriteLine("Student management app");

        try
        {
            StudentManagement student1 = new StudentManagement("Joy Ghosh Sourjo", new DateTime(2007,9,4), "CSE332211");
            StudentManagement student2 = new StudentManagement("Ajoy Ghosh Srijon", new DateTime(2008,9,4), "ENT332211");
            StudentManagement student3 = new StudentManagement("Ajoy Ghosh Srijonn", new DateTime(2022,9,4), "ENT332211");

            System.Console.WriteLine("All Students");
            System.Console.WriteLine($"Name : {student1.Name}, Age : {DateTime.Now.Year - student1?.BirthDate.Value.Year}, Roll Number : {student1.RollNumber}");
            System.Console.WriteLine($"Name : {student2.Name}, Age : {DateTime.Now.Year - student2?.BirthDate.Value.Year}, Roll Number : {student2.RollNumber}");
            System.Console.WriteLine($"Name : {student3.Name}, Age : {DateTime.Now.Year - student3?.BirthDate.Value.Year}, Roll Number : {student3.RollNumber}");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Error {ex.Message}");
        }
    }
}