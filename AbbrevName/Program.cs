using System;

namespace AbbrevName
{
    /*
        Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.

        The output should be two capital letters with a dot separating them.

        It should look like this:

        Sam Harris => S.H

        Patrick Feeney => P.F
    */
    class Program
    {
        static void Main(string[] args)
        {
            string name = "sven Programmierer";
            // string name = Console.ReadLine();
            AbbrevName(name);
        }

        public static string AbbrevName(string name)
        {
            
            string names = name.ToUpper();
            string[] nameArr = names.Split(' ');
            
            string dot = ".";
            
                      
            string firstItem = nameArr[0].Substring(0,1);
            string secondItem = nameArr[1].Substring(0,1);
            
            string msg = firstItem + dot + secondItem;
                    
            System.Console.WriteLine(msg);

            return msg;
        }
    }
}
