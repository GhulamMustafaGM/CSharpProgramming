using System;
public class Employee
{
    public Employee()
    {
        Console.WriteLine("Default Constructor Invoked \n");
    }
    public static void Main(string[] args)
    {
        Employee E1 = new Employee();
        Employee E2 = new Employee();
        Employee E3 = new Employee();
    }
}