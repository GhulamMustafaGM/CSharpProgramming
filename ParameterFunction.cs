// Define function by using parameter and no return type   

using System;
namespace ParameterFunction
{
    class Program
    {
        // User declared function without return type  
        public void Show(string message) // with Parameter  
        {
            Console.WriteLine("Hi, " + message);
            // with no return statement  
        }

        // With main function, execution entry point of the program  
        static void Main(string[] args)
        {
            Program program = new Program(); // executing Object  
            program.Show("John Doe"); // function is calling             
        }
    }
}