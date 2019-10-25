// Inner Continue Loop Statement 

using System;
public class InnerContinueLoop
{
    public static void Main(string[] args)
    {
        for (int a = 1; a <= 3; a++)
        {
            for (int b = 1; b <= 3; b++)
            {
                if (b == 2 && b == 2)
                {
                    continue;
                }
                Console.WriteLine(a + " " + b);
            }
        }
    }
}