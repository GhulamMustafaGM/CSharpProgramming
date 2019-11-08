// SortedDictionary<TKey, TValue>
using System;
using System.Collections.Generic;

public class SortedLinkedListProgram
{
    public static void Main(string[] args)
    {
        SortedDictionary<string, string> names = new SortedDictionary<string, string>();
        names.Add("1", "Shane");
        names.Add("4", "Petersson");
        names.Add("5", "Jane");
        names.Add("3", "Roland");
        names.Add("2", "Andersson");
        foreach (KeyValuePair<string, string> kv in names)
        {
            Console.WriteLine(kv.Key + " " + kv.Value);
        }
    }
}



/*




        */