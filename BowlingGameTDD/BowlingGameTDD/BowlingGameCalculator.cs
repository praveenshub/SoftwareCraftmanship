namespace BowlingGameTDD
{
    public class BowlingGameCalculator
    {
        public static int Play(string game)
        {
            var firstShot = game.Substring(0, 1);
            var secondShot = game.Substring(1, 1);

            if (firstShot == "X" || (firstShot == "-" && secondShot == "X"))
                return 10;

            if(firstShot == "-" && secondShot != "-")
                return int.Parse(secondShot);

            int score;
            int.TryParse(firstShot, out score);
            return score;
        }
    }
}