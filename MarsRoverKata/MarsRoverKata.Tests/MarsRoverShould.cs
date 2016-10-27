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

        [Test]
        public void Return_FinalCoordinatesAndHeading_Given_MovedForwardOneGridPoint_AndMaintainTheSameHeading()
        {
            string sizeOfThePlateau = "5 5";
            string positionOfTheRover = "0 0 N";
            string instructions = "M";
            MarsRover marsRover = new MarsRover();

            string finalCoordinates = marsRover.Move(sizeOfThePlateau, positionOfTheRover, instructions);

            finalCoordinates.Should().Be("0 1 N");
        }

        [Test]
        public void Return_FinalCoordinatesAndHeading_Given_MovedForwardTwoGridPoints_AndMaintainTheSameHeading()
        {
            string sizeOfThePlateau = "5 5";
            string positionOfTheRover = "0 0 N";
            string instructions = "MM";
            MarsRover marsRover = new MarsRover();

            string finalCoordinates = marsRover.Move(sizeOfThePlateau, positionOfTheRover, instructions);

            finalCoordinates.Should().Be("0 2 N");
        }

        [Test]
        public void Return_FinalCoordinatesAndHeading_Given_MovedForwardThreeGridPoints_AndMaintainTheSameHeading()
        {
            string sizeOfThePlateau = "5 5";
            string positionOfTheRover = "0 0 N";
            string instructions = "MMM";
            MarsRover marsRover = new MarsRover();

            string finalCoordinates = marsRover.Move(sizeOfThePlateau, positionOfTheRover, instructions);

            finalCoordinates.Should().Be("0 3 N");
        }

        [Test]
        public void Return_FinalCoordinatesAndHeading_Given_MovedEastOneGridPoint_AndMaintainTheSameHeading()
        {
            string sizeOfThePlateau = "5 5";
            string positionOfTheRover = "0 0 E";
            string instructions = "M";
            MarsRover marsRover = new MarsRover();

            string finalCoordinates = marsRover.Move(sizeOfThePlateau, positionOfTheRover, instructions);

            finalCoordinates.Should().Be("1 0 E");
        }

        [Test]
        public void Return_FinalCoordinatesAndHeading_Given_MovedEastTwoGridPoints_AndMaintainTheSameHeading()
        {
            string sizeOfThePlateau = "5 5";
            string positionOfTheRover = "0 0 E";
            string instructions = "MM";
            MarsRover marsRover = new MarsRover();

            string finalCoordinates = marsRover.Move(sizeOfThePlateau, positionOfTheRover, instructions);

            finalCoordinates.Should().Be("2 0 E");
        }
    }
}
