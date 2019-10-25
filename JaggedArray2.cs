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

public class JaggedArrayTest2
{
    public static void Main()
    {
        int[][] arr = new int[3][]{

        new int[] { 12, 22, 52, 68 },
        new int[] { 8, 6, 4, 2, 92, 2 },
        new int[] { 1, 9 }
        };

        // declar traverse array elements  
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