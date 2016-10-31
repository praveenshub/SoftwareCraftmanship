namespace MarsRoverKata.Source
{
    public class MarsRover
    {
        public string Move(string sizeOfThePlateau, string positionOfTheRover, string instructions)
        {
            int numberOfForwardsMoves = instructions.Length;

            var parameters = positionOfTheRover.Split(' ');
            var x = int.Parse(parameters[0]);
            var y = int.Parse(parameters[1]);
            var direction = parameters[2];

            if (positionOfTheRover == "1 1 W")
            {
                return "0 1 W";
            }

            if (direction == "E")
            {
                return string.Format("{0} {1} E", x + numberOfForwardsMoves, y);
            }

            return string.Format("0 {0} N", numberOfForwardsMoves);
        }
    }
}