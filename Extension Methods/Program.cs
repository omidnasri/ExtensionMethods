using System;
using Extension_Methods.Example1;

namespace Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "string1,string2,string3";
            var result = input.SplitByComma();
            Console.WriteLine(result[1]);
        }
    }
}
