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
            return String.Format("0 {0} N", numberOfForwardsMoves);
        }
    }
}