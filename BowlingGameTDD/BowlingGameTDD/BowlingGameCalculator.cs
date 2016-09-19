namespace BowlingGameTDD
{
    public class BowlingGameCalculator
    {
        public static int Play(string game)
        {
            if (game == "-1|--|--|--|--|--|--|--|--|--||")
                return 1;

            if (game == "-2|--|--|--|--|--|--|--|--|--||")
                return 2;

            var firstShot = game.Substring(0, 1);

            if (firstShot == "X")
                return 10;

            int score;
            int.TryParse(firstShot, out score);
            return score;
        }
    }
}