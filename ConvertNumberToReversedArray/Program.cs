using System;

namespace ConvertNumberToReversedArray
{
    class Program
    {
        /*
            Convert number to reversed array of digits
            Given a random non-negative number, you have to return the digits of this number within an array in reverse order.

            Example:
            348597 => [7,9,5,8,4,3]
        */
        static void Main(string[] args)
        {
            long n = 123456789;
            System.Console.WriteLine(ConvertNumberToArray(n));
        }
        static long[] ConvertNumberToArray(long n)
        {
            // convert long to array to reverse it
            string stringArr = n.ToString();
            char[] charArr = stringArr.ToCharArray(); 
            // return value
            long[] numberArr = new long[stringArr.Length];
            // reverse array
            Array.Reverse(charArr);
            
            // put values from charArr into numberArr
           
            for (int i = 0; i < stringArr.Length; i++)
            {
                numberArr[i] = charArr[i] - 48;
            }

            return numberArr;
        }
    }
}
