using System;
public class EnumProgram2
{
    public enum Season { WINTER = 10, SPRING, SUMMER, FALL }

    public static void Main()
    {
        int x = (int)Season.WINTER;
        int y = (int)Season.SUMMER;
        int z = (int)Season.FALL;

        Console.WriteLine("WINTER = {0}", x);
        Console.WriteLine("SUMMER = {0}", y);
        Console.WriteLine("FALL = {0}", z);
    }
}