using System;

// Abstract base class: Person
abstract class Person
{
    public string Name { get; set; }

    // Abstract method: must be implemented by derived classes
    public abstract void ShowRole();
}

// Student class inherits from Person
class Student : Person
{
    public string Major { get; set; }

    // Implementation of abstract method
    public override void ShowRole()
    {
        Console.WriteLine($"{Name} is a Student majoring in {Major}.");
    }

    // Behavior specific to Student
    public void Study()
    {
        Console.WriteLine($"{Name} is studying.");
    }
}

// Instructor class inherits from Person
class Instructor : Person
{
    public string Department { get; set; }

    // Implementation of abstract method
    public override void ShowRole()
    {
        Console.WriteLine($"{Name} is an Instructor in the {Department} department.");
    }

    // Behavior specific to Instructor
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

        // Demonstrate abstraction and specific behaviors
        student.ShowRole();
        student.Study();

        instructor.ShowRole();
        instructor.Teach();
    }
}
