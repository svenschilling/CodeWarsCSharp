using System;

namespace ReversedString
{
    class Program
    {
        /*
            Complete the solution so that it reverses the string passed into it.

            'world'  =>  'dlrow'
        */
        static void Main(string[] args)
        {
            string str = "World";
            System.Console.WriteLine(Solution(str));
        }
        public static string Solution(string str) 
        {
            string reversed = "";
            char[] test = str.ToCharArray();
            Array.Reverse(test);
            
            foreach (var item in test)
            {
                reversed += item;
            }
            
            return reversed;
        }
    }
}
