namespace RomanNumbersKata
{
    public class RomanNumberCalculator
    {
        public static string Convert(int number)
        {
            var romanNumbers = new[] { "I", "II", "III", "IV" };

            return romanNumbers[number - 1];
        }
    }
}