using System;
public class EAccount
{
    public int eid;
    public String ename;
    public static float rateOfInterest;
    public EAccount(int eid, String ename)
    {
        this.eid = eid;
        this.ename = ename;
    }
    static EAccount()
    {
        rateOfInterest = 9.5f;
    }
    public void display()
    {
        Console.WriteLine(eid + " " + ename + " " + rateOfInterest);
    }
}
class TestEmployee
{
    public static void Main(string[] args)
    {
        EAccount E1 = new EAccount(1011, "John cluch");
        EAccount E2 = new EAccount(1022, "Anderson Doe");
        E1.display();
        E2.display();

    }
}