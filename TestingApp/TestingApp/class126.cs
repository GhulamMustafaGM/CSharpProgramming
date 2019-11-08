// Threading Program: static method

using System;
using System.Threading;
public class ThreadProgram
{
    public static void Thread1()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}
public class ThreadExample
{
    public static void Main()
    {
        Thread t1 = new Thread(new ThreadStart(ThreadProgram.Thread1));
        Thread t2 = new Thread(new ThreadStart(ThreadProgram.Thread1));
        t1.Start();
        t2.Start();
    }
}