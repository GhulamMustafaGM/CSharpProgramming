/* we can declare three ways to initialize multidimensional array at the same time. 
 * 
 *int[,] arr = new int[3,3] { { 3, 2, 1 }, { 6, 5, 4 }, { 9, 8, 7 } };
 * 
 * 
 * int[,] arr = new int[,] { { 3, 2, 1 }, { 6, 5, 4 }, { 9, 8, 7 } };   // omit the size of array 
 * 
 * int[,] arr = { { 3, 2, 1 }, { 6, 5, 4 }, { 9, 8, 7 } }; // omit the new oerator 
 * 
 */

// Defined Multidimentinal Array 

using System;
public class MultiDiArray
{
    public static void Main(string[] args)
    {
        int[,] arr = { { 3, 2, 1 }, { 6, 5, 4 }, { 9, 8, 7 } }; //Array declaration and initialization  

        //Defined array traversal  
        for (int a = 0; a < 3; a++)
        {
            for (int b = 0; b < 3; b++)
            {
                Console.Write(arr[a, b] + " ");
            }
            Console.WriteLine();    //new line at each row  
        }
    }
}