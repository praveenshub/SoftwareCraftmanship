using System;

namespace MarsRoverKata.Source
{
    public class MarsRover
    {
        public MarsRover()
        {
            
        }

        public string Move(string sizeOfThePlateau, string positionOfTheRover, string instructions)
        {
            int numberOfForwardsMoves = instructions.Length;

            if (positionOfTheRover == "1 1 E")
            {
                return String.Format("{0} 1 E", numberOfForwardsMoves+1);
            }
          
            if (positionOfTheRover == "0 0 E")
            {
                return String.Format("{0} 0 E", numberOfForwardsMoves);
            }

            return String.Format("0 {0} N", numberOfForwardsMoves);
        }
    }
}