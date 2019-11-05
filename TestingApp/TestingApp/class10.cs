using System;
public class EmpAccount
{
    public int accno;
    public String name;
    public static float rateOfInterest = 8.8f;
    public EmpAccount(int accno, String name)
    {
        this.accno = accno;
        this.name = name;
    }

    public void display()
    {
        Console.WriteLine(accno + " " + name + " " + rateOfInterest);
    }
}
class TestAccount
{
    public static void Main(string[] args)
    {
        EmpAccount.rateOfInterest = 10.5f;//changing value  
        EmpAccount E1 = new EmpAccount(103, "Davaid");
        EmpAccount E2 = new EmpAccount(106, "Moses");
        E1.display();
        E2.display();

    }
}