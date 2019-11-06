﻿using System;
namespace AccessSpecifiers
{
    class InternalTest
    {
        internal string name = "Jone Kalle";
        internal void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            InternalTest internalTest = new InternalTest();
            // Accessing internal variable  
            Console.WriteLine("Hello " + internalTest.name);
            // Accessing internal function  
            internalTest.Msg("Rocksson Duck");
        }
    }
}