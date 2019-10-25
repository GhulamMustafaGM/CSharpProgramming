// Defined out parameter program 

using System;
namespace OutParameterProgram
{
    class Program
    {
        // User defined function  
        public void Show(out int num) // defined out parameter  
        {
            int square = 5;
            num = square;
            num *= num; // calculating value  
        }
        // with main function, execution entry point of the program  
        static void Main(string[] args)
        {
            int num = 50;
            Program program = new Program(); // executing Object  
            Console.WriteLine("Value before passing out variable " + num);
            program.Show(out num); // Passing out argument  
            Console.WriteLine("Value after recieving the out variable " + num);
        }
    }
}