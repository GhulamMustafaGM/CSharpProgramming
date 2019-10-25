// Defined Single Dimentional Array 

using System;
public class SingleDiArray
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5]; //declaring array  

        arr[0] = 10;    //initializing array  

        arr[2] = 20;

        arr[4] = 30;

        //defined traversing array
        
        for (int a = 0; a < arr.Length; a++)
        {
            Console.WriteLine(arr[a]);
        }
    }
}