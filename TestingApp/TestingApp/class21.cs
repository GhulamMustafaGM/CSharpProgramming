using System;
public class Employee
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
}
class TestEmployee
{
    public static void Main(string[] args)
    {
        Employee E1 = new Employee();
        E1.Name = "Kuble Khan";
        Console.WriteLine("Employee Name: " + E1.Name);
        Console.WriteLine("\n");

    }
}