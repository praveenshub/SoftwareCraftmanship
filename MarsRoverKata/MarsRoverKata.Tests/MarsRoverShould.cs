using FluentAssertions;
using MarsRoverKata.Source;
using NUnit.Framework;

namespace MarsRoverKata.Tests
{
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

        [TestCase("5 5", "0 0 N", "M", "0 1 N")]
        [TestCase("5 5", "0 0 N", "MM", "0 2 N")]
        [TestCase("5 5", "0 0 N", "MMM", "0 3 N")]
        public void Return_FinalCoordinatesAndHeading_Given_MovedForwardOneGridPoint_AndMaintainTheSameHeading(string sizeOfThePlateau, string positionOfTheRover, string instructions, string expected)
        {
            MarsRover marsRover = new MarsRover();

            string finalCoordinates = marsRover.Move(sizeOfThePlateau, positionOfTheRover, instructions);

            finalCoordinates.Should().Be(expected);
        }

        [TestCase("5 5", "0 0 E", "M", "1 0 E")]
        [TestCase("5 5", "0 0 E", "MM", "2 0 E")]
        [TestCase("5 5", "1 1 E", "M", "2 1 E")]
        public void Return_FinalCoordinatesAndHeading_Given_MovedForwardSomeGridPoints_AndMaintainTheSameHeading(string sizeOfThePlateau, string positionOfTheRover, string instructions, string expected)
        {
            MarsRover marsRover = new MarsRover();

            string finalCoordinates = marsRover.Move(sizeOfThePlateau, positionOfTheRover, instructions);

            finalCoordinates.Should().Be(expected);
        }
    }
}
