using System;
public class Address
{
    public string addressLine, city, state;
    public Address(string addressLine, string city, string state)
    {
        this.addressLine = addressLine;
        this.city = city;
        this.state = state;
    }
}
public class Employee
{
    public int Id;
    public string EmployeeName;
    public Address EmployeeAddress;//Employee HAS-A Address  
    public Employee(int Id, string EmployeeName, Address EmployeeAddress)
    {
        this.Id = Id;
        this.EmployeeName = EmployeeName;
        this.EmployeeAddress = EmployeeAddress;
    }
    public void display()
    {
        Console.WriteLine(Id + " " + EmployeeName + " " +
          EmployeeAddress.addressLine + " " + EmployeeAddress.city + " " + EmployeeAddress.state);
    }
}
public class TestAggregation
{
    public static void Main(string[] args)
    {
        Address a1 = new Address("Pergatan110, LGH:110 ", "Motala, ", "Ostergodland");
        Employee e1 = new Employee(1, "Andersson", a1);
        e1.display();
    }
}