namespace MarsRoverKata.Source
{
    public class MarsRover
    {
        public string Move(string sizeOfThePlateau, string positionOfTheRover, string instructions)
        {
            var roverPosition = positionOfTheRover.Split(' ');
            var roverX = int.Parse(roverPosition[0]);
            var roverY = int.Parse(roverPosition[1]);
            var roverDirection = roverPosition[2];

            foreach (var instruction in instructions)
            {
                if (instruction == 'M')
                {
                    if (roverDirection == "N")
                    {
                        roverY++;
                    }
                    else if (roverDirection == "E")
                    {
                        roverX++;
                    }
                    else if (roverDirection == "S")
                    {
                        roverY--;
                    }
                    else if (roverDirection == "W")
                    {
                        roverX--;
                    }
                }

                if (instruction == 'R')
                {
                    if (roverDirection == "N")
                    {
                        roverDirection = "E";
                    }
                    else if (roverDirection == "E")
                    {
                        roverDirection = "S";
                    }
                    else if (roverDirection == "S")
                    {
                        roverDirection = "W";
                    }
                    else if (roverDirection == "W")
                    {
                        roverDirection = "N";
                    }
                }
                
                if (instruction == 'L')
                {
                    if (roverDirection == "N")
                    {
                        roverDirection = "W";
                    }
                    else if (roverDirection == "E")
                    {
                        roverDirection = "N";
                    }
                    else if (roverDirection == "S")
                    {
                        roverDirection = "E";
                    }
                    else if (roverDirection == "W")
                    {
                        roverDirection = "S";
                    }
                }
            }

            return string.Format("{0} {1} {2}", roverX, roverY, roverDirection);
        }
    }
}