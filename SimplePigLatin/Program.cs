using System;
using System.Text;

namespace SimplePigLatin
{
    class Program
    {
        /*
            Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.

            Examples
            Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
            ! pass but not by hello world -> !ay
            Kata.PigIt("Hello world !");     // elloHay orldway !
        */
        static void Main(string[] args)
        {
            string str = "Hello world !";
            PigIt(str);
        }
        static string PigIt(string str)
        {            
            // split string to array
            string[] word = str.Split(' ');
            string[] appendStr = new string[word.Length];
            str = "";
                 
            // delete/take first char and append it + "ay"
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != "!")
                {
                    // take first char and make the append string from it
                    appendStr[i] = word[i].Substring(0,1) + "ay";
                     // delete first char on every word
                    word[i] = word[i].Remove(0,1);                   
                }

               
                // place appendStr behind every word
                word[i] += appendStr[i];
                // make a string with spaces 
                str += word[i] + ' ';
            }
            // cut off last char from string
            str = str.Remove(str.Length-1);

            return str;
        }
    }
}
