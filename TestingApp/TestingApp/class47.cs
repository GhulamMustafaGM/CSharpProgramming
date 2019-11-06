using System;

namespace AccessSpecifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            // Setting values to the properties  
            student.ID = "102";
            student.Name = "James Sand";
            student.Email = "James.Sand@email.com";

            // getting values  
            Console.WriteLine("ID = " + student.ID);
            Console.WriteLine("Name = " + student.Name);
            Console.WriteLine("Email = " + student.Email);
        }
    }
}