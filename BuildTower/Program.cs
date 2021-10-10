using System;

namespace BuildTower
{
    /*
        Build Tower by the following given argument:
        number of floors (integer and always greater than 0).

        Tower block is represented as *
            
        for example, a tower of 3 floors looks like below

        [
        '  *  ', 
        ' *** ', 
        '*****'
        ]
        and a tower of 6 floors looks like below

        [
        '     *     ', 
        '    ***    ', 
        '   *****   ', 
        '  *******  ', 
        ' ********* ', 
        '***********'
        ]

    */

    class Program
    {
        static void Main(string[] args)
        {

            TowerBuilder(4);
            
            int nFloors = 4;
            string[] columns = new string[nFloors];
            // spaltenbreite ermitteln
            int rowSpace = nFloors + nFloors - 1;

            for (int i = 0; i < nFloors; i++)
            {
                System.Console.WriteLine(" ");
                for (int j = 0; j < rowSpace; j++)
                {
                    System.Console.WriteLine("*");
                }
            }           
        }
        public static string[] TowerBuilder(int nFloors)
        {
            
            // spaltenbreite =
            string[] columns = new string[nFloors];
            int rowSpace = nFloors + nFloors - 1;

            for (int i = 0; i < nFloors; i++)
            {
                for (int j = 0; j < rowSpace; j++)
                {
                    System.Console.WriteLine("*");
                }
            }
            return new string[0];
        }

    }
}
