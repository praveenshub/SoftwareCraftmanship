using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace RomanNumbersKata
{
    public class RomanNumberCalculator
    {
        static readonly IDictionary<int, string> arabicToRomans = new Dictionary<int, string>
            {
                { 1, "I"},
                { 4, "IV" },
                { 5, "V" },
                { 9, "IX" },
                { 10, "X" },
                { 40, "XL" }
            };

        public static string Convert(int number)
        {
            var result = new StringBuilder();
            var remaining = number;

            remaining = AppendRomanNumerals(remaining, 40, result);
            remaining = AppendRomanNumerals(remaining, 10, result);
            remaining = AppendRomanNumerals(remaining, 9, result);
            remaining = AppendRomanNumerals(remaining, 5, result);
            remaining = AppendRomanNumerals(remaining, 4, result);
   
            for (var i = 0; i < remaining; i++)
            {
                result.Append("I");
            }

            return result.ToString();
        }

        private static int AppendRomanNumerals(int number, int key, StringBuilder result)
        {
            var roman = number;

            if (roman >= key)
            {
                result.Append(arabicToRomans[key]);
                roman -= key;
            }

            return roman;
        }
    }
}