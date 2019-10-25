// Define call by reference function   

using System;
namespace CallByReference
{
    class Program
    {
          
        public void Show(ref int num) // user declared function 
        {
            num *= num; // calculate value
            
            Console.WriteLine("Value inside the display function " + num);
            // with no return   
        }
        // with main function, execution entry point of the program  

        static void Main(string[] args)
        {
            int num = 50;

            Program program = new Program(); // executing Object
            
            Console.WriteLine("Value before calling the function " + num);

            program.Show( ref num); // Calling Function by passing value            

            Console.WriteLine("Value after calling the function " + num);
        }
    }
}