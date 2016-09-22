using System;
using System.Collections.Generic;

namespace RomanNumbersKata
{
    public class RomanNumberCalculator
    {
        public static string Convert(int number)
        {
            IDictionary<int, string> arabicToRomans = new Dictionary<int, string>
            {
                { 1, "I"},
                { 2, "II"},
                { 3, "III" },
                { 4, "IV" },
                { 5, "V" }
            };

            return arabicToRomans[number];
        }
    }
}