using System;
namespace AccessSpecifiers
{
    class Program
    {
        private string name = "Ricksson Roland";
        private void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            // Accessing private variable  
            Console.WriteLine("Hello " + program.name);
            // Accessing private function  
            program.Msg("Tony Byre");
        }
    }
}