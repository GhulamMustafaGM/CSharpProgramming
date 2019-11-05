using System;
public class EnumProgram
{
    public enum Season { WINTER, SPRING, SUMMER, FALL }

    public static void Main()
    {
        int x = (int)Season.WINTER;
        int y = (int)Season.SUMMER;
        int z = (int)Season.FALL;

        Console.WriteLine("WINTER = {0}", x);
        Console.WriteLine("SUMMER = {0}", y);
        Console.WriteLine("Fall = {0}" , z);
    }
}