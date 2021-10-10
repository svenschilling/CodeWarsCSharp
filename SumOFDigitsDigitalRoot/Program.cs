using System;

namespace SumOFDigitsDigitalRoot
{
    class Program
    {
        /*
            Digital root is the recursive sum of all the digits in a number.

            Given n, take the sum of the digits of n. If that value has more than one digit, 
            continue reducing in this way until a single-digit number is produced. The input will be a non-negative integer.

            Examples
                16  -->  1 + 6 = 7
               942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
            132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
            493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2
        */
        static void Main(string[] args)
        {
            long n = 942;
            
            System.Console.WriteLine(DigitalRoot(n));
        }
        static int DigitalRoot(long n)
        {
            // to string to manipulate and test first if length is below 1
            string valueToString = n.ToString(); 
            // split numbers                       
            int[] numInt = new int[valueToString.Length];
            // split string to char
            char[] charArray = valueToString.ToCharArray();
            int sum = (int)n;
            

            // build a string copy of sum to check length in the while loop
            string testLength = sum.ToString();   

            // reset sum before loop starts
            sum = 0;
            // while > then 1 digits, calculate every position
            while (testLength.Length > 1)
            {
                // ! convert sum into char array again ?
                // put split numbers into array
                for (int i = 0; i < testLength.Length; i++)
                {
                    numInt[i] =  Convert.ToInt32(charArray[i]- 48);
                    // add all numbers
                    sum += numInt[i];
                    

                }
                // ! has given 15 as length when it should be 2
                testLength = sum.ToString();

            }


 

            return sum;
        }
    }
}
