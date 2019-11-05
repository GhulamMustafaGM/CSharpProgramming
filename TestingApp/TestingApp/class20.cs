﻿using System;
public class EnumProgram
{
    public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    public static void Main()
    {
        foreach (Days d in Enum.GetValues(typeof(Days)))
        {
            Console.WriteLine(d);
        }
    }
}