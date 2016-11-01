namespace MarsRoverKata.Source
{
    public class MarsRover
    {
        public string Move(string sizeOfThePlateau, string positionOfTheRover, string instructions)
        {
            var roverStartingPosition = positionOfTheRover.Split(' ');
            var x = int.Parse(roverStartingPosition[0]);
            var y = int.Parse(roverStartingPosition[1]);
            var direction = roverStartingPosition[2];

            foreach (var instruction in instructions)
            {
                if (instruction == 'M')
                {
                    if (direction == "N")
                    {
                        y++;
                    }
                    else if (direction == "E")
                    {
                        x++;
                    }
                    else if (direction == "S")
                    {
                        y--;
                    }
                    else if (direction == "W")
                    {
                        x--;
                    }
                }

                if (instruction == 'R')
                {
                    if (direction == "N")
                    {
                        direction = "E";
                    }
                    else if (direction == "E")
                    {
                        direction = "S";
                    }
                    else if (direction == "S")
                    {
                        direction = "W";
                    }
                    else if (direction == "W")
                    {
                        direction = "N";
                    }
                }
                
                if (instruction == 'L')
                {
                    if (direction == "N")
                    {
                        direction = "W";
                    }
                    else if (direction == "E")
                    {
                        direction = "N";
                    }
                    else if (direction == "S")
                    {
                        direction = "E";
                    }
                    else if (direction == "W")
                    {
                        direction = "S";
                    }
                }
            }

            return string.Format("{0} {1} {2}", x, y, direction);
        }
    }
}