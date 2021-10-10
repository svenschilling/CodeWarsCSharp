using System;

namespace RgbToHex
{
    /*
        The rgb function is incomplete. Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned. Valid decimal values for RGB are 0 - 255. Any values that fall out of that range must be rounded to the closest valid value.

        Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.

        The following are examples of expected output values:

        Rgb(255, 255, 255) # returns FFFFFF
        Rgb(255, 255, 300) # returns FFFFFF
        Rgb(0,0,0) # returns 000000
        Rgb(148, 0, 211) # returns 9400D3
    */
    class Program
    {
        static void Main(string[] args)
        {
            int r = 148;
            int g = -20;
            int b = 211;         
            
            System.Console.WriteLine(RgbToHex(r,g,b));
        }
        static string RgbToHex(int r, int g, int b)
        {
            // convert integer to hex in a string variable
            string rHex = r.ToString("X2");
            string gHex = g.ToString("X2");
            string bHex = b.ToString("X2");

            // ! use math.max min to reduce code
            // if there is a negative number then shorten it
            if (r < 0)
            {
                rHex = "00";
            }
            if (r > 255)
            {
                rHex = "FF";
            }
            if (g < 0)
            {
                gHex = "00";
            }            
            if (g > 255)
            {
                gHex = "FF";
            }
            if (b < 0)
            {
                bHex = "00";
            }            
            if (b > 255)
            {
                bHex = "FF";
            }



            string hexValue = rHex+gHex+bHex;

            return hexValue;
        }
    }
}
