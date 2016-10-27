﻿using FluentAssertions;
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


        [Test]
        public void Return_FinalCoordinatesAndHeading_Given_StartingOneOneMovedEastOneGridPoints_AndMaintainTheSameHeading()
        {
            string sizeOfThePlateau = "5 5";
            string positionOfTheRover = "1 1 E";
            string instructions = "M";
            MarsRover marsRover = new MarsRover();

            string finalCoordinates = marsRover.Move(sizeOfThePlateau, positionOfTheRover, instructions);

            finalCoordinates.Should().Be("2 1 E");
        }
    }
}
