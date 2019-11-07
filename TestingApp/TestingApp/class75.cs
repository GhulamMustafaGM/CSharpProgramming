// String LastIndexOfAny()

using System;
using System.Text;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "abracadabra";
        char[] ch = { 'r', 'b' };
        int index = s1.LastIndexOfAny(ch);  //Finds 'r' at the last  

        Console.WriteLine(index);
    }
}