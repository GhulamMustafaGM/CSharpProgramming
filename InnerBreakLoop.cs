// Inner Break Loop Program 

using System;
public class InnerBreakProgram

{
    public static void Main(string[] args)
    {

        for (int a = 1; a <= 3; a++)
        {
            for (int b = 1; b <= 3; b++)
            {
                if (a == 2 && b == 2)
                {
                    break;
                }
                Console.WriteLine(a + " " + b);
            }
        }
    }
}