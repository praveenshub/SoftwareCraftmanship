﻿using FluentAssertions;
using NUnit.Framework;
using StringCalculatorTDD;

namespace StringCalculatorTDDTests
{
    [TestFixture]
    class StringCalculatorShould
    {
        [Test]
        public void ReturnZeroForEmptyString()
        {
            var result = StringCalculator.Add(string.Empty);

            result.Should().Be(0);
        }

        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("3", 3)]
        public void ReturnsIntegerRepresentationGivenASingleNumberAsString(string number, int expectedNumber)
        {
            var result = StringCalculator.Add(number);

            result.Should().Be(expectedNumber);
        }

        [TestCase("0,1",1)]
        [TestCase("1,0",1)]
        [TestCase("1,1",2)]
        public void ReturnsIntegerRepresentationOfSumGivenTwoNumbersAsString(string numbers, int expectedSum)
        {
            var result = StringCalculator.Add(numbers);

            result.Should().Be(expectedSum);
        }

        [TestCase("1,2,3", 6)]
        [TestCase("0,1,2,3,4,555", 565)]
        public void ReturnsIntegerRepresentationOfSumGivenManyNumbersAsString(string numbers, int expectedSum)
        {
            var result = StringCalculator.Add(numbers);

            result.Should().Be(expectedSum);
        }

        [TestCase("1\n2,3", 6)]
        [TestCase("//;\n1;2", 3)]
        [TestCase("//!\n1!2", 3)]
        public void ReturnsIntegerRepresentationOfSumGivenManyNumbersWithAnyDelimitedString(string numbers, int expectedSum)
        {
            var result = StringCalculator.Add(numbers);

            result.Should().Be(expectedSum);
        }

    }
}
