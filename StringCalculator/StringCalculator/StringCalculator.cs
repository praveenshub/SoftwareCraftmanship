using System.Linq;

namespace StringCalculatorTDD
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (numbers.Length == 1)
                return int.Parse(numbers);

            if (numbers.Length == 3)
            {
                var numbersToParse = numbers.Split(',');
                return numbersToParse.Sum(i => int.Parse(i));
            }

            return 0;
        }
    }
}