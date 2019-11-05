using System;
public class Employee
{
    public int StdId;
    public String StudentName;
    public float salary;
    public void insert(int a, String k, float s)
    {
        StdId = a;
        StudentName = k;
        salary = s;
    }
    public void display()
    {
        Console.WriteLine(StdId + " " + StudentName + " " + salary);
    }
}
class TestEmployee
{
    public static void Main(string[] args)
    {
        Employee E1 = new Employee();
        Employee E2 = new Employee();
        E1.insert(103, "Hanrik", 890000f);
        E2.insert(105, "David", 490000f);
        E1.display();
        E2.display();
        Console.WriteLine("\n");
    }
}