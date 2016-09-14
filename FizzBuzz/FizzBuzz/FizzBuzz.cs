namespace FizzBuzz
{
    internal class FizzBuzz
    {
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";

        public string Process(int number)
        {
            return $"{GetFizzBuzz(number)}";
        }

        private static string GetFizzBuzz(int number)
        {
            if (IsFizz(number))
            {
                if (IsBuzz(number))
                {
                    return $"{FIZZ}{BUZZ}";
                }
                return FIZZ;
            }
            return IsBuzz(number) ? BUZZ : number.ToString();
        }

        private static bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }

        private static bool IsFizz(int number)
        {
            return number % 3 == 0;
        }
    }
}