// Accessing Array Elements

using System;

namespace ArrayProgram
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int[] n = new int[15]; /* n is an array of 15 integers */
            int i, j;

            /* initialize elements of array n */
            for (i = 0; i < 15; i++)
            {
                n[i] = i + 100;
            }

            /* output each array element's value */
            for (j = 0; j < 15; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
            Console.ReadKey();
        }
    }
}