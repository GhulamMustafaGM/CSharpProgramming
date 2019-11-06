using System;
namespace AccessModifiers
{
    class ProtectedTest
    {
        protected string name = "Jane kon";
        protected void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class Program : ProtectedTest
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            // Accessing protected variable  
            Console.WriteLine("Hello " + program.name);
            // Accessing protected function  
            program.Msg("James Don");
        }
    }
}