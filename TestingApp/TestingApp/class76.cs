// String LastIndexOfAny() Method

using System;
using System.Text;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s1 = "abracadabra";
        char[] ch = { 't', 'b' };
        int index = s1.LastIndexOfAny(ch);  //Finds 'b' at the last  

        Console.WriteLine(index);
    }
}