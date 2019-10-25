// Define function by using no parameter and return type   

using System;
namespace FunctionProgram
{
    class Program
    {
        // User declared function without return type  
        public void Show() // with no Parameter  
        {
            Console.WriteLine("This shows non-parameterized function");
            // with no return statement  
        }

        // With main function, execution entry point of the program  
        static void Main(string[] args)
        {
            Program program = new Program(); // executing Object  
            program.Show(); // function is calling             
        }
    }
}