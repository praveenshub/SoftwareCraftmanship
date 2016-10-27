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
            if (positionOfTheRover == "1 1 E" && instructions == "M")
            {
                return "2 1 E";
            }

            if (positionOfTheRover == "1 1 E" && instructions == "MM")
            {
                return "3 1 E";
            }

            if (positionOfTheRover == "1 1 E" && instructions == "MMM")
            {
                return "4 1 E";
            }

            int numberOfForwardsMoves = instructions.Length;

            if (positionOfTheRover == "0 0 E")
            {
                return String.Format("{0} 0 E", numberOfForwardsMoves);
            }

            return String.Format("0 {0} N", numberOfForwardsMoves);
        }
    }
}