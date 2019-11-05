using System;
public class Student2
{
    public int id2;
    public String name2;
}
class TestStudent
{
    public static void Main(string[] args)
    {
        Student2 s2 = new Student2();
        s2.id2 = 104;
        s2.name2 = "Jane Doe \n";
        Console.WriteLine(s2.id2);
        Console.WriteLine(s2.name2);

    }
}