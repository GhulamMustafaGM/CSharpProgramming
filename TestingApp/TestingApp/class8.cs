using System;
public class Student
{
    public int StdId;
    public String StdName;
    public float salary;
    public Student(int StdId, String StdName, float salary)
    {
        this.StdId = StdId;
        this.StdName = StdName;
        this.salary = salary;
    }
    public void display()
    {
        Console.WriteLine(StdId + " " + StdName + " " + salary);
    }
}
class TestStudent
{
    public static void Main(string[] args)
    {
        Student S1 = new Student (104, "Jane Moon", 890000f);
        Student S2 = new Student(102, "Jone Doe", 490000f);
        S1.display();
        S2.display();

    }
}