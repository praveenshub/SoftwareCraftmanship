namespace MarsRoverKata.Source
{
    public class MarsRover
    {
        public string Move(string sizeOfThePlateau, string positionOfTheRover, string instructions)
        {
            var parameters = positionOfTheRover.Split(' ');
            var x = int.Parse(parameters[0]);
            var y = int.Parse(parameters[1]);
            var direction = parameters[2];

            foreach (var instruction in instructions)
            {
                if (instruction == 'M')
                {
                    switch (direction)
                    {
                        case "N":
                            y++;
                            break;
                        case "E":
                            x++;
                            break;
                        case "S":
                            y--;
                            break;
                        case "W":
                            x--;
                            break;
                    }
                }

                if (instruction == 'R')
                {
                    switch (direction)
                    {
                        case "N":
                            direction = "E";
                            break;
                        case "E":
                            direction = "S";
                            break;
                        case "S":
                            direction = "W";
                            break;
                        case "W":
                            direction = "N";
                            break;
                    }
                }
                
                if (instruction == 'L')
                {
                    switch (direction)
                    {
                        case "N":
                            direction = "W";
                            break;
                        case "W":
                            direction = "S";
                            break;
                        case "S":
                            direction = "E";
                            break;
                        case "E":
                            direction = "N";
                            break;
                    }
                }
            }

            return string.Format("{0} {1} {2}", x, y, direction);
        }
    }
}