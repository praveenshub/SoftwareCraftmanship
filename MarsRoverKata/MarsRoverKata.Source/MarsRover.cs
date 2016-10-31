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

            var direction = positionOfTheRover.Split(' ')[2];
            var xPos = int.Parse(positionOfTheRover.Split(' ')[0]);
            var yPos = int.Parse(positionOfTheRover.Split(' ')[1]);

            if (direction == "E")
            {
                return String.Format("{0} {1} E", xPos + numberOfForwardsMoves, yPos);
            }

            return String.Format("0 {0} N", numberOfForwardsMoves);
        }
    }
}