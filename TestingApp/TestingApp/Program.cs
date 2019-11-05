using System;
public class Student
{
    int Id;   
    String Name; 

    public static void Main(string[] args)
    {
        Student Std1 = new Student(); //creating an object of Student    
        Std1.Id = 101;
        Std1.Name = "John Doe";
        Console.WriteLine(Std1.Id);
        Console.WriteLine(Std1.Name);
        Console.WriteLine("\n");

    }
}