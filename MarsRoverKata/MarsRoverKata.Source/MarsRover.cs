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

                    if (direction == "W")
                    {
                        x--;
                    }
                    
                    if (direction == "S")
                    {
                        y--;
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