using System;

namespace IsTriangle
{
    /*
        Implement a method that accepts 3 integer values a, b, c. The method should return true if a triangle can be built with the sides of given length 
        and false in any other case.

        (In this case, all triangles must have surface greater than 0 to be accepted).
         
    */
    class Program
    {
        static void Main(string[] args)
        {
            IsTriangle(1,2,4);
        }
        static bool IsTriangle(int a,int b, int c)
        {         
            if(a+b>c && b+c>a && c+a>b)
            {
                System.Console.WriteLine("true");
                return true;
            }
            System.Console.WriteLine("false");
            return false;
        }
    }
}

