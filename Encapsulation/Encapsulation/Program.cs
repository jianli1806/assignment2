using System;

// Abstract base class: Person
abstract class Person
{
    // Private field
    private string name;

    // Public property to access private field
    public string Name
    {
        get { return name; }
        set
        {
            // Optional: Add validation here if needed
            name = value;
        }
    }

    // Abstract method
    public abstract void ShowRole();
}

// Student class
class Student : Person
{
    // Private field
    private string major;

    // Public property
    public string Major
    {
        get { return major; }
        set { major = value; }
    }

    public override void ShowRole()
    {
        Console.WriteLine($"{Name} is a Student majoring in {Major}.");
    }

    public void Study()
    {
        Console.WriteLine($"{Name} is studying.");
    }
}

// Instructor class
class Instructor : Person
{
    // Private field
    private string department;

    // Public property
    public string Department
    {
        get { return department; }
        set { department = value; }
    }

    public override void ShowRole()
    {
        Console.WriteLine($"{Name} is an Instructor in the {Department} department.");
    }

    public void Teach()
    {
        Console.WriteLine($"{Name} is teaching.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.Name = "Alice";
        student.Major = "Computer Science";

        Instructor instructor = new Instructor();
        instructor.Name = "Dr. Smith";
        instructor.Department = "Mathematics";

        student.ShowRole();
        student.Study();

        instructor.ShowRole();
        instructor.Teach();
    }
}