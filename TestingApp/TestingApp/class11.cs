using System;
public class EmpAccount
{
    public int accno;
    public String name;
    public static int count = 0;
    public EmpAccount(int accno, String name)
    {
        this.accno = accno;
        this.name = name;
        count++;
    }

    public void display()
    {
        Console.WriteLine(accno + " " + name);
    }
}
class TestAccount
{
    public static void Main(string[] args)
    {
        EmpAccount e1 = new EmpAccount(107, "Donald Duck");
        EmpAccount e2 = new EmpAccount(108, "John Doe");
        EmpAccount e3 = new EmpAccount(109, "Roland Carlsson");
        
        e1.display();
        e2.display();
        e3.display();
        Console.WriteLine("\n");
        Console.WriteLine("Total Objects are: " + EmpAccount.count);
        Console.WriteLine("\n");
    }
}