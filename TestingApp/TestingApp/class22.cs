using System;
public class Student
{
    private string stdname;

    public string stdName
    {
        get
        {
            return stdname;
        }
        set
        {
            stdname = value + " at Linkoping University!";

        }
    }
}
class TestEmployee
{
    public static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.stdName = "William";
        Console.WriteLine("Student Name: " + s1.stdName);
    }
}