namespace RomanNumbersKata.Tests
{
    using FluentAssertions;

    using NUnit.Framework;

    public class RomanNumberCalculatorShould
    {
        [Test]
        public void ReturnI_Given1()
        {
            string romanNumber = RomanNumberCalculator.Convert(1);

            romanNumber.Should().Be("I");
        } 
    }
}
