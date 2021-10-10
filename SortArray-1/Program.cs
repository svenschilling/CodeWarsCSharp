using System;

namespace SortArray_1
{
    class Program
    {
        /*
            Just a simple sorting usage. Create a function that returns the elements of the input-array / list sorted in lexicographical order.
        */
        static void Main(string[] args)
        {
            string[] names = {"Günther","Peter","Alf","Serkan","Erdal","Lars"};
            System.Console.WriteLine(SortMe(names));
        }
        static string[] SortMe(string[] names)
        {
            Array.Sort(names);
            return names;
        }
    }
}
