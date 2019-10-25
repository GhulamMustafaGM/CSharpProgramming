// Defined out parameter program2 

using System;
namespace OutParameterProgram2
{
    class Program
    {
        // User-defined function  
        public void Show(out int i, out int j) // Defiend out parameter  
        {
            int square = 5;
            i = square;
            j = square;
            
            // calculating value  
            i *= i;
            j *= j;
        }
        // with main function, execution entry point of the program  
        static void Main(string[] args)
        {
            int num1 = 50, num2 = 100;

            Program program = new Program(); //  Object  

            Console.WriteLine("Value before passing \n num1 = " + num1 + " \n num2 = " + num2);

            program.Show(out num1, out num2); // Passing out argument  

            Console.WriteLine("Value after passing \n num1 = " + num + " \n num2 = " + num2);
        }
    }
}