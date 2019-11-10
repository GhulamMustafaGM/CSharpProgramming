// factorial program

using System;
public class FactorialProgram
{
    public static void Main(string[] args)
    {
        int a, fact = 1, number;
        Console.Write("Enter any Number: ");
        number = int.Parse(Console.ReadLine());
        for (a = 1; a <= number; a++)
        {
            fact = fact * a;
        }
        Console.Write("Factorial of " + number + " is: " + fact);
        Console.WriteLine("\n");
    }
}