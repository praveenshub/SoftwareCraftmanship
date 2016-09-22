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
        [TestCase("VI", 6)]
        [TestCase("VII", 7)]
        [TestCase("VIII", 8)]
        [TestCase("IX", 9)]
        [TestCase("X", 10)]
        public void ReturnRoman_GivenNumber(string expectedRomanNumber, int number)
        {
            string romanNumber = RomanNumberCalculator.Convert(number);

            romanNumber.Should().Be(expectedRomanNumber);
        }
    }
}
