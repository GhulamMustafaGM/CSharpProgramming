/* we can declare three ways to initialize array at the same time. 
 * 
 *int[] arr = new int[3] {20,30,40,50};
 * 
 * 
 * int[] arr = new int[] {40, 20, 50, 10};   // omit the size of array 
 * 
 * int[] arr = {10,30,50,20,60}; // omit the new oerator 
 * 
 */

// Defined Multidimentinal Array 

using System;
public class MultiDiArray
{
    public static void Main(string[] args)
    {
        int[,] arr = new int[3, 3]; //declaration of 2D array  

        arr[0, 1] = 20; //declaration  

        arr[1, 2] = 30;

        arr[2, 0] = 50;

        //traversal  

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