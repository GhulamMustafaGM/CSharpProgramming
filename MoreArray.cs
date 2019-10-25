/* can declare three ways to initialize array at the same time. 
 * 
 *int[] arr = new int[3] {20,30,40,50};
 * 
 * 
 * int[] arr = new int[] {40, 20, 50, 10};   // omit the size of array 
 * 
 * int[] arr = {10,30,50,20,60}; // omit the new oerator 
 * 
 */

using System;
public class MoreArray
{
    public static void Main(string[] args)
    {
        int[] arr = { 10, 30, 50, 20, 60 }; // defined and Initialization of array  

        //traversing array  

        for (int a = 0; a < arr.Length; a++)
        {
            Console.WriteLine(arr[a]);
        }
    }
}