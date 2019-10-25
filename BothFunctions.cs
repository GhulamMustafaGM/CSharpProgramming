// Define function by using parameter and no return type   

using System;
namespace ParameterFunction
{
    class Program
    {
        // User declared function   
        public void Show(string message) // with Parameter  
        {
            Console.WriteLine("Inside display function");

            return message;
            // with return statement  
        }

        // With main function, execution entry point of the program  
        static void Main(string[] args)
        {
            Program program = new Program(); // executing Object
            string message = program.Show("Superman!");
            program.Show("Hi, ") + message; // function is calling             
        }
    }
}