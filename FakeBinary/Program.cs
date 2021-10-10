using System;
using System.Linq;

namespace FakeBinary
{
    /*
        Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the resulting string.
    */
    class Program
    {
        static void Main(string[] args)
        {
            string y = "21312456652";
            System.Console.WriteLine(FakeBin(y));
        }
        static string FakeBin(string x)
        {
            string result = "";
            char[] stringToCharArr = x.ToCharArray();
            for (int i = 0; i < stringToCharArr.Length; i++)
            {
                
                if (stringToCharArr[i] - 48 < 5)
                {
                    stringToCharArr[i] = '0';
                }
                else
                {
                    stringToCharArr[i] = '1';
                }
                result += stringToCharArr[i];
            }

            return result;
        }
    }
}
