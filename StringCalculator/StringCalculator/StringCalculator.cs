using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculatorTDD
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers))
                return 0;
            var args = GetIntArrayFromCommaDelimitedString(numbers);
            return args.Sum(x => x);
        }

        private static IEnumerable<int> GetIntArrayFromCommaDelimitedString(string numbers)
        {
            numbers = ReplaceNonCommaDelimitedNumbersWithComma(numbers);
            return numbers.Split(',').Select(int.Parse);
        }

        private static string ReplaceNonCommaDelimitedNumbersWithComma(string numbers)
        {
            numbers = ReplaceDelimitersWithComma(numbers);

            numbers = numbers.Replace("\n", ",");
            return numbers;
        }

        private static string ReplaceDelimitersWithComma(string numbers)
        {
            const string pattern = "^//(.)\n";
            var regex = new Regex(pattern);
            var match = regex.Match(numbers);
            if (match.Success)
            {
                var delimiter = match.Groups[1].Value;
                numbers = regex.Replace(numbers, string.Empty);
                numbers = numbers.Replace(delimiter, ",");
            }
            return numbers;
        }
    }
}