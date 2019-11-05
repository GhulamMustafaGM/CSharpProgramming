using System;
public class Student
{
    public int StdId;
    public String StudentName;
    public void insert(int a, String k)
    {
        StdId = a;
        StudentName = k;
    }
    public void display()
    {
        Console.WriteLine(StdId + " " + StudentName);
    }
}
class TestStudent
{
    public static void Main(string[] args)
    {
        Student std1 = new Student();
        Student std2 = new Student();
        std1.insert(100, "Johan");
        std2.insert(101, "Erick \n");
        std1.display();
        std2.display();

    }
}