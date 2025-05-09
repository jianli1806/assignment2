using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate an array of numbers (default length 10)
        int[] numbers = GenerateNumbers(10);
        
        // Reverse the array
        Reverse(numbers);
        
        // Print the reversed array
        PrintNumbers(numbers);
    }

    // Method to generate an array of numbers from 1 to length
    static int[] GenerateNumbers(int length = 10)
    {
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = i + 1;
        }
        return numbers;
    }

    // Method to reverse the contents of the array
    static void Reverse(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n / 2; i++)
        {
            int temp = array[i];
            array[i] = array[n - i - 1];
            array[n - i - 1] = temp;
        }
    }

    // Method to print the contents of the array
    static void PrintNumbers(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
