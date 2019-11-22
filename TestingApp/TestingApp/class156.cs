// CSharp Program

using System;

namespace RectangleProgram
{
    class RectangleApp
    {
        //variables

        public double length;
        public double width;

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
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
}