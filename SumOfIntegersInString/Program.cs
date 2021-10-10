using System;

namespace SumOfIntegersInString
{
    /*
        Your task in this kata is to implement a function that calculates the sum of the integers inside a string. 
        For example, in the string "The30quick20brown10f0x1203jumps914ov3r1349the102l4zy dog", the sum of the integers is 3635.

        Note: only positive integers will be tested.
    */
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "73fssd23";
            System.Console.WriteLine(SumOfIntegersInString(testString));
        }
        static int SumOfIntegersInString(string s)
        {
            int sum = 0;
            string[] substringNumbers = new string[s.Length];
            int countNumberLength = 0;
            int startPosition = 0;
            int numberTemp = 0;
                  
            for (int i = 0; i < s.Length; i++)
            {
                // when its a number
                if (char.IsNumber(s,i))
                {  
                    // set start position if its a new found number
                    if (countNumberLength == 0)
                    {
                        startPosition = i;
                    }
                    
                    countNumberLength++;
                    // if the last position in the array is reached ?????
                    if (i == s.Length -1)
                    {
                        substringNumbers[i] = s.Substring(startPosition,countNumberLength);
                    }
                }
                // when its not a number
                else
                {
                    /*
                    // save number into array
                    substringNumbers[i] = s.Substring(startPosition,countNumberLength);
                    */

                    // reset counter
                    countNumberLength = 0;
                }

            }
            /*
            // convert string array to int array
            int[] stringToInt = Array.ConvertAll(substringNumbers,s => int.Parse(s));
            
            // iterate trough array and add those numbers
            foreach (var item in stringToInt)
            {
                sum += item;
            }
            */

            return sum;
        }
    }
}
