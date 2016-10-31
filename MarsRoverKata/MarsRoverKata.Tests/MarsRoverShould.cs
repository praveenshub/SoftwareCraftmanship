﻿namespace MarsRoverKata.Tests
{
    using FluentAssertions;

    using MarsRoverKata.Source;

    using NUnit.Framework;

    [TestFixture]
    public class MarsRoverShould
    {
        [Test]
        public void Return_FinalCoordinatesAndHeading_Given_NoInputIsSent()
        {
            MarsRover marsRover = new MarsRover();

            string startingCoordinates = marsRover.Move("5 5", "0 0 N", string.Empty);

            startingCoordinates.Should().Be("0 0 N");
        }

        [TestCase("0 0 N", "M", "0 1 N")]
        [TestCase("0 0 N", "MM", "0 2 N")]
        [TestCase("0 0 N", "MMM", "0 3 N")]
        [TestCase("0 0 E", "M", "1 0 E")]
        [TestCase("0 0 E", "MM", "2 0 E")]
        [TestCase("1 1 E", "M", "2 1 E")]
        [TestCase("1 1 E", "MM", "3 1 E")]
        [TestCase("1 1 E", "MMM", "4 1 E")]
        [TestCase("2 1 E", "M", "3 1 E")]
        [TestCase("2 1 E", "MM", "4 1 E")]
        [TestCase("1 1 W", "M", "0 1 W")]
        [TestCase("2 1 W", "M", "1 1 W")]
        [TestCase("3 1 W", "M", "2 1 W")]
        [TestCase("3 1 S", "M", "3 0 S")]
        [TestCase("3 2 S", "M", "3 1 S")]
        [TestCase("3 3 S", "M", "3 2 S")]
        public void Return_FinalCoordinatesAndHeading_Given_MovedForwardSomeGridPoints_AndMaintainTheSameHeading(string positionOfTheRover, string instructions, string expected)
        {
            MarsRover marsRover = new MarsRover();

            string finalCoordinates = marsRover.Move("5 5", positionOfTheRover, instructions);

            finalCoordinates.Should().Be(expected);
        }
    }
}
