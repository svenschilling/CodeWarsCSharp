using System;

namespace EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FibonacciNumberGenerator(10));
        }
        public static int FibonacciNumberGenerator(int howManyCreated)
        {
            int EvenNumbers = 0;
            int[] fibNumbers = new int[howManyCreated];

            int fib1 = 0;
            int fib2 = 1;
            
            for (int i = 0; i < howManyCreated; i++)
            {
                int tempFib = 0;
                

                tempFib = fib1 + fib2;

                System.Console.WriteLine(fib1);
                System.Console.WriteLine(fib2);

                fib1 = fib2;



            }


            return EvenNumbers;
        }
    }
}
