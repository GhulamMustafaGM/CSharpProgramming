// Private Access Specifier

using System;

namespace RectangleProgram
{
    class RectangleApp
    {
        //Variables of members
        private double width;
        private double length;
        public void Acceptdetails()
        {
            Console.WriteLine("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            RectangleApp r = new RectangleApp();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}