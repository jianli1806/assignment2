using System;

// Base class: Person
abstract class Person
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Virtual method for salary calculation
    public virtual double CalculateSalary()
    {
        // Default implementation: no salary
        return 0.0;
    }

    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name}.");
    }

    public abstract void ShowRole();
}

// Student class
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

    // No override for CalculateSalary, inherits default (0.0)
}

// Instructor class
class Instructor : Person
{
    private string department;
    public string Department
    {
        get { return department; }
        set { department = value; }
    }

    private double monthlySalary;
    public double MonthlySalary
    {
        get { return monthlySalary; }
        set { monthlySalary = value; }
    }

    public override void ShowRole()
    {
        Console.WriteLine($"{Name} is an Instructor in the {Department} department.");
    }

    public void Teach()
    {
        Console.WriteLine($"{Name} is teaching.");
    }

    // Override virtual method to provide specific salary calculation
    public override double CalculateSalary()
    {
        // For example, 12 months salary
        return MonthlySalary * 12;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Use polymorphism: both are Person references
        Person student = new Student { Name = "Alice", Major = "Computer Science" };
        Person instructor = new Instructor { Name = "Dr. Smith", Department = "Mathematics", MonthlySalary = 4000 };

        student.Greet();
        student.ShowRole();
        Console.WriteLine($"Salary: {student.CalculateSalary()}");

        instructor.Greet();
        instructor.ShowRole();
        Console.WriteLine($"Salary: {instructor.CalculateSalary()}");
    }
}
