// Dictionary<TKey, TValue> 
using System;
using System.Collections.Generic;

public class LinkedListProgram
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> names = new Dictionary<string, string>();
        names.Add("1", "Shane");
        names.Add("2", "Petersson");
        names.Add("3", "Jane");
        names.Add("4", "Roland");
        names.Add("5", "Andersson");

        foreach (KeyValuePair<string, string> kv in names)
        {
            Console.WriteLine(kv.Key + " " + kv.Value);
        }
    }
}