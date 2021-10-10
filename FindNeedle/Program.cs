using System;


namespace FindNeedle
{
    class Program
    {
        /*
            Can you find the needle in the haystack?

            Write a function findNeedle() that takes an array full of junk but containing one "needle"

            After your function finds the needle it should return a message (as a string) that says:

            "found the needle at position " plus the index it found the needle, so:

            find_needle(["hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk"])             
        */        
        public int positionOfNeedle = 0;

        static void Main(string[] args)
        {
            object[] needleArr = {"hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk"};
                                   
            System.Console.WriteLine(FindNeedle(needleArr));
          
        }


        public static string FindNeedle(object[] haystack)
        {
            return "found the needle at position " + Array.IndexOf(haystack, "needle");
        }

    }
}
