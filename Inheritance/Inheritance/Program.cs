using System;

// Base class: Person (now with shared implementation)
abstract class Person
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Shared method for all persons
    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name}.");
    }

    // Abstract method to be implemented by derived classes
    public abstract void ShowRole();
}

// Student inherits from Person
class Student : Person
{
    private string major;
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

// Instructor inherits from Person
class Instructor : Person
{
    private string department;
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
        Student student = new Student { Name = "Alice", Major = "Computer Science" };
        Instructor instructor = new Instructor { Name = "Dr. Smith", Department = "Mathematics" };

        // Inheritance: Both classes use the Greet() method from Person
        student.Greet();
        student.ShowRole();
        student.Study();

        instructor.Greet();
        instructor.ShowRole();
        instructor.Teach();
    }
}
