using System;  
using One;  
using Two;  

namespace One
{
    public class Hej
    {
        public void sayHej() { Console.WriteLine("Hej Namespace"); }
    }
}

namespace Two
{
    public class Welcome
    {
        public void sayWelcome() { Console.WriteLine("Welcome Namespace"); }
    }
}
public class TestingNamespace
{
    public static void Main()
    {
        Hej h1 = new Hej();
        Welcome w1 = new Welcome();
        h1.sayHej();
        w1.sayWelcome();
    }
}