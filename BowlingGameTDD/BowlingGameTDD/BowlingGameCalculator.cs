using System.Linq;

namespace BowlingGameTDD
{
    public class BowlingGameCalculator
    {
        public static int Play(string game)
        {
            var score = 0;
            var frames = game.Split('|');

            var firstShot = game.Substring(0, 1);
            var secondShot = game.Substring(1, 1);

            if(IsStrike(frames.First()) || IsSpare(frames.FirstOrDefault()))
                return 10;

            if(firstShot == "-" && secondShot != "-")
                return int.Parse(secondShot);

            int.TryParse(firstShot, out score);
            return score;
        }

        private static bool IsGutter(string shot)
        {
            return shot == "-";
        }

        private static bool IsStrike(string frame)
        {
            return frame.Substring(0, 1) == "X";
        }

        private static bool IsSpare(string frame)
        {
            return frame.Substring(1, 1) == "X";
        }
    }
}