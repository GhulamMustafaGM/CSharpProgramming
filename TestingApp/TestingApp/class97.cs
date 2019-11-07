// try/catch/finally 

using System;
public class ExProgram
{
    public static void Main(string[] args)
    {
        try
        {
            int x = 10;
            int y = 0;
            int z = x / y;
        }
        catch (NullReferenceException e) { Console.WriteLine(e); }
        finally { Console.WriteLine("Finally block is executed"); }
        Console.WriteLine("Rest of the code");
    }
}