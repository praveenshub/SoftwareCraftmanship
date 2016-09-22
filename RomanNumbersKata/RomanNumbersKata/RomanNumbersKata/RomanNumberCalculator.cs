namespace RomanNumbersKata
{
    public class RomanNumberCalculator
    {
        public static string Convert(int number)
        {
            var romanNumbers = new[] { "I", "II", "III", "IV", "V" };

            return romanNumbers[number - 1];
        }
    }
}