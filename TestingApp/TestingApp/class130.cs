﻿// Threading Program: Abort() method

using System;
using System.Threading;
public class MyThread
{
    public void Thread1()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(200);
        }
    }
}
public class ThreadExample
{
    public static void Main()
    {
        Console.WriteLine("Start of Main");
        MyThread mt = new MyThread();
        Thread t1 = new Thread(new ThreadStart(mt.Thread1));
        Thread t2 = new Thread(new ThreadStart(mt.Thread1));

        t1.Start();
        t2.Start();
        try
        {
            t1.Abort();
            t2.Abort();
        }
        catch (ThreadAbortException tae)
        {
            Console.WriteLine(tae.ToString());
        }
        Console.WriteLine("End of Main");
    }
}