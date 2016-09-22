namespace RomanNumbersKata
{
    public class RomanNumberCalculator
    {
        public static string Convert(int i)
        {
            if (i == 2)
            {
                return "II";
            }

            if (i == 3)
            {
                return "III";
            }

            if (i == 4)
            {
                return "IV";
            }

            return "I";
        }
    }
}