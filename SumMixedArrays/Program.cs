using System;

namespace SumMixedArrays
{
    /*
        Given an array of integers as strings and numbers, return the sum of the array values as if all were numbers.

        Return your answer as a number.
    */
    class Program
    {
        static void Main(string[] args)
        {
            object[] x = new object[] {"9",7,"6"};
            
            System.Console.WriteLine(SumMix(x));
        }
        public static int SumMix(object[] x)
        {
            int sum = 0;
            foreach (var item in x)
            {
                sum += Convert.ToInt32(item);
            }
            return sum;            
        }
    }
}
