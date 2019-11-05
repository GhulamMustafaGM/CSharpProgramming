using System;
public class StdAccount
{
    public int stdaccno;
    public String stdname;
    public static float rateOfInterest = 8.8f;
    public StdAccount(int stdaccno, String stdname)
    {
        this.stdaccno = stdaccno;
        this.stdname = stdname;
    }

    public void display()
    {
        Console.WriteLine(stdaccno + " " + stdname + " " + rateOfInterest);
    }
}
class TestAccount
{
    public static void Main(string[] args)
    {
        StdAccount s1 = new StdAccount(101, "Creem");
        StdAccount s2 = new StdAccount(102, "Bosh");
        s1.display();
        s2.display();

    }
}