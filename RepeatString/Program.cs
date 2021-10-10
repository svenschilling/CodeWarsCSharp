using System;

namespace RepeatString
{
    /*
        Write a function called repeatStr which repeats the given string string exactly n times.

        repeatStr(6, "I") // "IIIIII"
        repeatStr(5, "Hello") // "HelloHelloHelloHelloHello"
    */
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine(RepeatString(3,"*"));
        }
        static string RepeatString(int n, string s)
        {
            string text = "";
            for (int i = 0; i < n; i++)
            {
                
                text += s;
            }
            
            return text;
        }
    }
}
