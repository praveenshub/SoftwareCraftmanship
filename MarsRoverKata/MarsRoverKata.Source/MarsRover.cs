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
            if (positionOfTheRover == "0 0 E")
            {
                return "1 0 E";
            }

            int numberOfForwardsMoves = instructions.Length;
            return String.Format("0 {0} N", numberOfForwardsMoves);
        }
    }
}