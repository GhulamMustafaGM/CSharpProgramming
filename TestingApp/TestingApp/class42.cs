// Access modifiers or specifiers, five have consisted public, protected, internal, protected internal, private


using System;
namespace AccessModifiers
{
    class PublicTest
    {
        public string name = "John Doe";
        public void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PublicTest publicTest = new PublicTest();
            // Accessing public variable  
            Console.WriteLine("Hello " + publicTest.name);
            // Accessing public function  
            publicTest.Msg("Anderson anders");
        }
    }
}