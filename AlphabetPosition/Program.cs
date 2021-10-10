using System;

namespace exercises
{
    class Program
    {
        /*
            program that gives back the alphabet position of giving letters
        */
        static void Main(string[] args)
        {
            AlphabetPosition("abc");         
        }
    
        public static string AlphabetPosition(string text)
        {
                
            int indexNumber = 0;
            
            char[] splitText = text.ToCharArray();
            text = "";

            foreach (var item in splitText)
            {
                indexNumber = char.ToUpper(item) - 64;
                // take every char and append to string
                text += indexNumber.ToString();

                
            }
                  
            return text;
        }
    }
}
