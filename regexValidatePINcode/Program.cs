using System;
using System.Text.RegularExpressions;

namespace regexValidatePINcode
{
    /*
        ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.

        If the function is passed a valid PIN string, return true, else return false.

        Examples
            "1234"   -->  true
            "12345"  -->  false
            "a234"   -->  false
    */

    class Program
    {
        static void Main(string[] args)
        {
            string pin = "123446";
            System.Console.WriteLine("validatePin: " + ValidatePin(pin));
        }
        public static bool ValidatePin(string pin)
        {
            Regex regRule = new Regex(@"[0-9]+");
            Regex exRule = new Regex(@"\D+");
            
            Match match = regRule.Match(pin);
            Match matchLetter = exRule.Match(pin);

            if (!matchLetter.Success)
            { 
                if (pin.Length == 4 || pin.Length == 6 && match.Success)
                {               
                    System.Console.WriteLine("digits");
                    return true;
                } 
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
