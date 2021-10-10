using System;
using System.Linq;

namespace XO
{
    /*
        Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.

        Examples input/output:

        XO("ooxx") => true
        XO("xooxx") => false
        XO("ooxXm") => true
        XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
        XO("zzoo") => false
    */
    class Program
    {
        static void Main(string[] args)
        {
            string xo = "oOxXm";
            System.Console.WriteLine(XO(xo));
        }
        static bool XO(string xo)
        {
            
            string xoLower = xo.ToLower();
            char[] charArray = xoLower.ToCharArray();
            // LINQ request 0
            var linqResultO = from test in charArray
                             where test == 'o'
                             select test;
            // LINQ request x
            var linqResultX = from test in charArray
                             where test == 'x'
                             select test;

            if (linqResultX.Count() == linqResultO.Count())
            {
                return true;
            }                   
            
            return false;
        }   
    }
}
