using System;
public class Student
{
    public Student()
    {
        Console.WriteLine("Constructor Invoked \n");
        
    }
    ~Student()
    {
        Console.WriteLine("Destructor Invoked \n");
    }
}
class TestEmployee
{
    public static void Main(string[] args)
    {
        Student S1 = new Student();
        Student S2 = new Student();
        
    }
    
}