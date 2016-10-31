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

            if (direction == "S")
            {
                return string.Format("{0} {1} S", x, y - numberOfForwardsMoves);
            }

            if (direction == "W")
            {
                return string.Format("{0} {1} W", x - numberOfForwardsMoves, y);
            }

            if (direction == "E")
            {
                return string.Format("{0} {1} E", x + numberOfForwardsMoves, y);
            }

            foreach (var instruction in instructions)
            {
                if (instruction == 'M')
                {
                    if (direction == "N")
                    {
                        y++;    
                    }

                    if (direction == "E")
                    {
                        x++;
                    }
                }

                if (instruction == 'R')
                {
                    direction = "E";
                }
            }

            return string.Format("{0} {1} {2}", x, y, direction);
        }
    }
}