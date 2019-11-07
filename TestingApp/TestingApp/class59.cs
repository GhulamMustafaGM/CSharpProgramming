// String GetEnumerator()

using System;
public class StringProgram
{
    public static void Main(string[] args)
    {
        string s3 = "Hej C#";
        CharEnumerator ch = s3.GetEnumerator();

        while(ch.MoveNext())
        {
            Console.WriteLine(ch.Current);
        }
        
    }
}