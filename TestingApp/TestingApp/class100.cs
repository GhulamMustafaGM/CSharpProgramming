﻿// Checked using checked 

using System;
namespace CSharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }
        }
    }
}