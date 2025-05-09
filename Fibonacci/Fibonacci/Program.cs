using System;

class Program
{
    static void Main(string[] args)
    {
        // Print the first 10 Fibonacci numbers
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
        Console.WriteLine();
    }

    // Recursive method to return the nth Fibonacci number
    static int Fibonacci(int n)
    {
        // Base cases: first and second Fibonacci numbers are 1
        if (n == 1 || n == 2)
            return 1;

        // Recursive case: sum of the two previous numbers
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
