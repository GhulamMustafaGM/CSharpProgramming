using System;
public class EnumEProgram
{
    public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    public static void Main()
    {
        int a = (int)Days.Sun;
        int b = (int)Days.Mon;
        int d = (int)Days.Tue;
        int e = (int)Days.Wed;
        int f = (int)Days.Thu;
        int g = (int)Days.Fri;
        int c = (int)Days.Sat;

        Console.WriteLine("Sun = {0}", a);
        Console.WriteLine("Mon = {0}", b);
        Console.WriteLine("Tue = {0}", d);
        Console.WriteLine("Wed = {0}", e);
        Console.WriteLine("Thu = {0}", f);
        Console.WriteLine("Fri = {0}", g);
        Console.WriteLine("Sat = {0}", c);
    }
}