using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzz
    {
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";

        public string Process(int i)
        {
            if (IsMultipleOfThree(i))
            {
                if (IsMultipleOfFive(i))
                {
                    return $"{FIZZ}{BUZZ}";
                }

                return FIZZ;
            }

            if (IsMultipleOfFive(i))
            {
                return BUZZ;
            }

            return i.ToString();
        }

        private static bool IsMultipleOfFive(int i)
        {
            return i % 5 == 0;
        }

        private static bool IsMultipleOfThree(int i)
        {
            return i % 3 == 0;
        }
    }
}