using System;
public class Employee
{
    public int StdId;
    public String StudentName;
    public float salary;
    public Employee(int a, String k, float s)
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
        Employee E1 = new Employee(103, "James Bond", 890000f);
        Employee E2 = new Employee(105, "Johan aronsson", 490000f);
        E1.display();
        E2.display();
        Console.WriteLine("\n");
    }
}