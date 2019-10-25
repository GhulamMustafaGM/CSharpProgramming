// Goto Loop Statement 

using System;
public class GotoProgram
{
    public static void Main(string[] args)
    {
    ineligible:
        Console.WriteLine("You are not eligible to ID!");

        Console.WriteLine("Enter your age:\n");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age < 18)
        {
            goto ineligible;
        }
        else
        {
            Console.WriteLine("You are eligible to ID!");
        }

    }
}