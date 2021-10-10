using System;

namespace GetNthEvenNumber
{
    class Program
    {
        /*
            Return the Nth Even Number

            Example(Input --> Output)

            1 --> 0 (the first even number is 0)
            3 --> 4 (the 3rd even number is 4 (0, 2, 4))
            100 --> 198
            1298734 --> 2597466
        */
        static void Main(string[] args)
        {
            int n = 100;
            System.Console.WriteLine(NthEven(n));
        }
        static int NthEven(int n)
        {
            int evenNumbers = 0;
            
            evenNumbers = n * 2 - 2; 

            return evenNumbers;
        }
    }
}
