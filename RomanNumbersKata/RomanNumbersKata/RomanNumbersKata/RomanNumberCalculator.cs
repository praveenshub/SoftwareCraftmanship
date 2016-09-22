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
                { 6, "VI" },
                { 7, "VII" }
            };

        public static string Convert(int number)
        {
            if (arabicToRomans.ContainsKey(number))
            {
                return arabicToRomans[number];
            }

            return arabicToRomans[1] + Convert(number - 1);
        }
    }
}