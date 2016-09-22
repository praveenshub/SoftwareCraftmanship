namespace RomanNumbersKata.Tests
{
    using FluentAssertions;

    using NUnit.Framework;

    public class RomanNumberCalculatorShould
    {
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        public void ReturnRoman_GivenNumber(string expectedRomanNumber, int number)
        {
            string romanNumber = RomanNumberCalculator.Convert(number);

            romanNumber.Should().Be(expectedRomanNumber);
        }
    }
}
