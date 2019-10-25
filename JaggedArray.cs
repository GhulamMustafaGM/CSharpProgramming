/* we can declare three ways to initialize multidimensional array at the same time. 
 * 
 *int[,] arr = new int[3,3] { { 3, 2, 1 }, { 6, 5, 4 }, { 9, 8, 7 } };
 * 
 * 
 * int[,] arr = new int[,] { { 3, 2, 1 }, { 6, 5, 4 }, { 9, 8, 7 } };   // omit the size of array 
 * 
 * int[,] arr = { { 3, 2, 1 }, { 6, 5, 4 }, { 9, 8, 7 } }; // omit the new oerator 
 * 
 * and 
 * 
 * int [][] arr= new int[2][]    // Jagged array or array of arrays
 * 
 */

// Defined Jagged Array 

public class JaggedArrayTest
{
    public static void Main()
    {
        int[][] arr = new int[2][];// Declare the array  

        arr[0] = new int[] { 12, 22, 55, 78 };// Initialize the array          
        arr[1] = new int[] { 40, 62, 47, 45, 50, 64 };

        // Traverse array elements  
        for (int a = 0; a < arr.Length; a++)
        {
            for (int b = 0; b < arr[a].Length; b++)
            {
                System.Console.Write(arr[a][b] + " ");
            }
            System.Console.WriteLine();
        }
    }
}