namespace MarsRoverKata.Tests
{
    using FluentAssertions;

    using MarsRoverKata.Source;

    using NUnit.Framework;

    [TestFixture]
    public class MarsRoverShould
    {
        [TestCase("0 0 N", "", "0 0 N")]
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
        [TestCase("3 3 S", "MM", "3 1 S")]
        [TestCase("0 0 N", "MR", "0 1 E")]
        [TestCase("0 0 N", "MRM", "1 1 E")]
        [TestCase("1 0 N", "ML", "1 1 W")]
        [TestCase("1 0 N", "MLL", "1 1 S")]
        [TestCase("1 0 N", "MLLL", "1 1 E")]
        [TestCase("1 0 N", "MLLLL", "1 1 N")]
        [TestCase("0 0 N", "MRRM", "0 0 S")]
        [TestCase("0 0 N", "MRRMR", "0 0 W")]
        [TestCase("0 0 N", "MRRMRR", "0 0 N")]        
        public void Return_FinalCoordinatesAndHeading_Given_MovedForwardSomeGridPoints_AndMaintainTheSameHeading(string positionOfTheRover, string instructions, string expected)
        {
            MarsRover marsRover = new MarsRover();

            string finalCoordinates = marsRover.Move("5 5", positionOfTheRover, instructions);

            finalCoordinates.Should().Be(expected);
        }
    }
}
