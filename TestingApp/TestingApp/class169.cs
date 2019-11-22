// Getting Substring

using System;

namespace StringProgram
{

    class StringProg
    {

        static void Main(string[] args)
        {
            string str = "Last night I dreamt of Pettersson";
            Console.WriteLine(str);
            string substr = str.Substring(23);
            Console.WriteLine(substr);
        }
    }
}