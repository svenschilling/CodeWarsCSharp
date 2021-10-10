using System;

namespace SumOfNumbers
{
    /*
        Given two integers a and b, which can be positive or negative, find the sum of all the integers between and including them and return it. 
        If the two numbers are equal return a or b.

        Note: a and b are not ordered!

        Examples
        GetSum(1, 0) == 1   // 1 + 0 = 1
        GetSum(1, 2) == 3   // 1 + 2 = 3
        GetSum(0, 1) == 1   // 0 + 1 = 1
        GetSum(1, 1) == 1   // 1 Since both are same
        GetSum(-1, 0) == -1 // -1 + 0 = -1
        GetSum(-1, 2) == 2  // -1 + 0 + 1 + 2 = 2
    
        also auch alle zahlen zwischen den gegebenen zahlen
    */
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine(GetSum(-1,-10));
        }
        static int GetSum(int a, int b)
        {
            int c = 0;
            
            if (a != b)
            {
                // rework this part i think i need another temp var
                for (int i = a; i <= b; i++)
                {
                    c += i;
                    System.Console.WriteLine($"c: {c}");
                }
            }
            else 
            {
                c = a;
            }

            return c;
        }
    }
}
