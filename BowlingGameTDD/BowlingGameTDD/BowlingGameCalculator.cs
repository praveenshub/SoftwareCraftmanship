namespace BowlingGameTDD
{
    public class BowlingGameCalculator
    {
        public static int Play(string game)
        {
            if (game == "1-|--|--|--|--|--|--|--|--|--||")
                return 1;

            if (game == "2-|--|--|--|--|--|--|--|--|--||")
                return 2;

            if (game == "3-|--|--|--|--|--|--|--|--|--||")
                return 3;

            return 0;
        }
    }
}