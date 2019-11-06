using System;
namespace FirstOne
{
    public class Hi
    {
        public void sayHi() { Console.WriteLine("Hi FirstOne Namespace"); }
    }
}
namespace SecondOne
{
    public class Hi
    {
        public void sayHi() { Console.WriteLine("Hi SecondOne Namespace"); }
    }
}
public class TestingNamespace
{
    public static void Main()
    {
        FirstOne.Hi h1 = new FirstOne.Hi();
        SecondOne.Hi h2 = new SecondOne.Hi();
        h1.sayHi();
        h2.sayHi();

    }
}