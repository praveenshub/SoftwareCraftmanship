using System;
using System.Collections.Generic;
using System.Linq;

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
            numbers = numbers.Replace("//;\n", "");
            numbers = numbers.Replace("\n", ",");
            numbers = numbers.Replace(";", ",");
            return numbers;
        }
    }
}