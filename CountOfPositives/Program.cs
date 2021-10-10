using System;

namespace CountOfPositives
{

    /*
        Given an array of integers.

        Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers.

        If the input array is empty or null, return an empty array.

    */
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = {12,-67,23,-23,-1};
            CountPositivesSumNegatives(intArray);
        }

        public static int[] CountPositivesSumNegatives(int[] input)
        {
            int sumOfNegatives = 0b0;
            int countOfPositives = 0;
            
            foreach (var item in input)
            {               
                if (Math.Sign(item) == 1)
                {
                    countOfPositives += 1;    
                }
                if (Math.Sign(item) == -1)
                {
                    sumOfNegatives += item;   
                }
            }
            System.Console.WriteLine(countOfPositives);
            System.Console.WriteLine(sumOfNegatives);
            return null; //return an array with count of positives and sum of negatives
        }
    }
}
