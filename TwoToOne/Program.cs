using System;

namespace TwoToOne
{
    /*    
        Take 2 strings s1 and s2 including only letters from a to z. Return a new sorted string, the longest possible, 
        containing distinct letters - each taken only once - coming from s1 or s2.

        Examples:
        a = "xyaabbbccccdefww"
        b = "xxxxyyyyabklmopq"
        longest(a, b) -> "abcdefklmopqwxy"

        a = "abcdefghijklmnopqrstuvwxyz"
        longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"           
    */
    class Program
    {
        static void Main(string[] args)
        {
            string a = "xyaabbbccccdefww";
            string b = "xxxxyyyyabklmopq";

            System.Console.WriteLine(Longest(a,b));
        }
        static string Longest(string s1, string s2)
        {
            /*
            - add strings
            - split them to chars
            - compare one position with every position and if there is a duplicate then delete it 
            or
            - add string
            - sort string 
            - if next position == first position -> delete | mb with indexOf
            - 
            */

            string composedString = s1 + s2;
            char[] charArr = composedString.ToCharArray();
            
            // as long as he finds no doubles anymore
            while (true)
            {
                
            }



            return composedString;
        }
    }
}
