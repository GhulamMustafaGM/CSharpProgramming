using System;
public class Employee
{
    private static int counter;

    public Employee()
    {
        counter++;
    }
    public static int Counter
    {
        get
        {
            return counter;
        }
    }
}
class TestEmployee
{
    public static void Main(string[] args)
    {
        Employee E1 = new Employee();
        Employee E2 = new Employee();
        Employee E3 = new Employee();

        //E1.Counter = 10;//Compile Time Error: Can't set value  

        Console.WriteLine("No. of Employees: " + Employee.Counter);
    }
}