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

// Defined Passing Array to Function and output to be minimum number

using System;

public class MinNunArray
{
    static void printMin(int[] arr)
    {
        int min = arr[0];
        for (int a = 1; a < arr.Length; a++)
        {
            if (min > arr[a])
            {
                min = arr[a];
            }
        }
        Console.WriteLine("Minimum value is: " + min);
    }
    public static void Main(string[] args)
    {
        int[] arr1 = { 22, 30, 40, 55, 20, 60 };
        int[] arr2 = { 11, 21, 42, 12, 55 };

        printMin(arr1); //passing array to function  
        printMin(arr2);
    }
}