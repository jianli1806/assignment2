using System;

// Abstraction: Abstract class defines a template for derived classes
abstract class Animal
{
    // Encapsulation: Private field, accessible via public property
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Abstraction: Abstract method, must be implemented by derived classes
    public abstract void Speak();
}

// Inheritance: Dog inherits from Animal
class Dog : Animal
{
    // Polymorphism: Override Speak method
    public override void Speak()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}

// Inheritance: Cat inherits from Animal
class Cat : Animal
{
    // Polymorphism: Override Speak method
    public override void Speak()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Encapsulation: Name property is used to set/get the name
        Animal myDog = new Dog();
        myDog.Name = "Buddy";
        
        Animal myCat = new Cat();
        myCat.Name = "Whiskers";

        // Polymorphism: Both objects are Animal, but correct Speak() is called
        myDog.Speak();
        myCat.Speak();
    }
}
