// See https://aka.ms/new-console-template for more information
/*
    Welcome Adventurer. Your aim is to navigate the maze and reach the finish point without touching any walls. Doing so will kill you instantly!
    Task
    You will be given a 2D array of the maze and an array of directions. Your task is to follow the directions given. 
    If you reach the end point before all your moves have gone, you should return Finish. 
    If you hit any walls or go outside the maze border, you should return Dead. 
    If you find yourself still in the maze after using all the moves, you should return Lost.
    The Maze array will look like

    maze = [[1,1,1,1,1,1,1],
            [1,0,0,0,0,0,3],
            [1,0,1,0,1,0,1],
            [0,0,1,0,0,0,1],
            [1,0,1,0,1,0,1],
            [1,0,0,0,0,0,1],
            [1,2,1,0,1,0,1]]
    ..with the following key

        0 = Safe place to walk
        1 = Wall
        2 = Start Point
        3 = Finish Point
    direction = ["N","N","N","N","N","E","E","E","E","E"] == "Finish"
    Rules
    1. The Maze array will always be square i.e. N x N but its size and content will alter from test to test.

    2. The start and finish positions will change for the final tests.

    3. The directions array will always be in upper case and will be in the format of N = North, E = East, W = West and S = South.

    4. If you reach the end point before all your moves have gone, you should return Finish.

    5. If you hit any walls or go outside the maze border, you should return Dead.

    6. If you find yourself still in the maze after using all the moves, you should return Lost.
*/


namespace CodeWars
{
    class Kata
    {
        static void Main()
        {
            string[] directions = {"N","N","N","N","N","E","E","E","E","E"};
            int[,] maze = {{1,1,1,1,1,1,1},
                           {1,0,0,0,0,0,3},
                           {1,0,1,0,1,0,1},
                           {0,0,1,0,0,0,1},
                           {1,0,1,0,1,0,1},
                           {1,0,0,0,0,0,1},
                           {1,2,1,0,1,0,1}};
            System.Console.WriteLine(mazeRunner(maze, directions));
            
        }

        static string mazeRunner(int[,] maze, string[] directions)
        {
            int[,] playerPosition = new int[maze.Length,maze.Length];
                        
            int x = 0;
            int y = 0;

            // move to next position and check number

            System.Console.WriteLine(maze.Length);

            // get starting coordinates
            for (int i = 0; i < maze.Length; i++)
            {
                for (int j = 0; j < maze.Length; j++)
                {
                    if (maze[i,j] == 2)
                    {
                        x = maze[i,j];
                        System.Console.WriteLine(x);
                    }
                }
            }


            
            return "";







            /*
            // create 2d array 
            int[,] playerPosition = new int[maze.Length,maze.Length];
            // loop to find start position where its equal 2
            for (int i = 0; i < maze.Length; i++)
            {
                for (int j = 0; j < maze.Length; j++)
                    
                    // save position 
                    if (maze[i,j] == 2)
                    {          
                        playerPosition.SetValue(0,i,j);
                        System.Console.WriteLine("i: " + i);
                        System.Console.WriteLine("j: " + j);
                    }
                }
            }
            
            
            
            // loop through every step
            for (int k = 0; k < directions.Length; k++)
            {
                if (directions[i] == "N")
                {
                    
                }
                if (directions[i] == "W")
                {
                    
                }
                if (directions[i] == "E")
                {
                    
                }
                if (directions[i] == "S")
                {
                    
                }
                
                if (i == directions.Length)
                {
                    return "Lost";
                }
            }
            */


            

            
        }     
    }
}
