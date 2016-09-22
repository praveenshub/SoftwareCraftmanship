using System;
using System.Collections.Generic;

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
                { 10, "X" }
            };

        public static string Convert(int number)
        {
            if (arabicToRomans.ContainsKey(number))
            {
                return arabicToRomans[number];
            }

            if (number > 10)
            {
                const string romanForFive = "X";
                return romanForFive + Convert(number - 10);
            }

            if (number > 5)
            {
                const string romanForFive = "V";
                return romanForFive + Convert(number - 5);
            }

            return arabicToRomans[1] + Convert(number - 1);
        }
    }
}