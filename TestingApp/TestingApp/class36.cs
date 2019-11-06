using System;
public class Car
{
    public string color = "Black";

}
public class Toyota : Car
{
    public string color = "Gray";
}
public class TestingCar
{
    public static void Main()
    {
        Car c = new Toyota();
        Toyota t = new Toyota();

        Console.WriteLine(c.color);
        Console.WriteLine(t.color);

    }
}