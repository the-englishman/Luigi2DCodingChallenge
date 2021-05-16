using System;
namespace LuigiChallenge
{
    public class Luigi
    {
        public Luigi()
        {
        }


//Guide Luigi home by following the trail of "0"s from left to right and top to bottom in the 2D matrix.

//Give him directions with two commands:

//"Down" or "Right";

//Example:
//input:

//        [4,0,4]
//        [5,0,0]
//        [6,9,0]
//        [8,3,0]

//        output:

//String "Down Right Down Down"

//(Note: In all the tests Luigi will have clear path.So there will only be a "0" below or to the right of each other.No isolated "0"s or "0"s moving back left.)


        public string GoHome2D(int[][] map)
        {
            string directions = "";
            for (int row = 0; row < map.Length; row++)
            {
                for (int col = 0; col < map[row].Length-1; col++)
                {
                    if(map[row][col] == 0 && map[row][col + 1] == 0)
                    {
                        directions += "Right ";
                    }
                }   if (row < map.Length-1)
                {
                    directions += "Down ";
                }
            }
            return directions.Trim();
        }
    }
}
