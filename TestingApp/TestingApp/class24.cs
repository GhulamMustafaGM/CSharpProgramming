using System;
public class Employee
{
    public float salary = 45000;
}
public class Programmer : Employee
{
    public float bonus = 12000;
}
class TestInheritance
{
    public static void Main(string[] args)
    {
        Programmer P1 = new Programmer();

        Console.WriteLine("Salary: " + P1.salary);
        Console.WriteLine("Bonus Salary: " + P1.bonus);

    }
}