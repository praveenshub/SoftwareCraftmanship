using BowlingGameTDD;
using FluentAssertions;
using NUnit.Framework;

namespace BowlingGameTDDTests
{
    [TestFixture]
    class BowlingGameCalculatorShould
    {
        [Test]
        public void ReturnZeroScore_GivenPlayerMissesEveryShot()
        {
            var score = BowlingGameCalculator.Play("--|--|--|--|--|--|--|--|--|--||");

            score.Should().Be(0);
        }

        [TestCase("1-|--|--|--|--|--|--|--|--|--||", 1)]
        [TestCase("2-|--|--|--|--|--|--|--|--|--||", 2)]
        [TestCase("3-|--|--|--|--|--|--|--|--|--||", 3)]
        public void ReturnScore_GivenPlayerKnocksPinsOnlyInTheFirstFrame(string game, int expectedScore)
        {
            var score = BowlingGameCalculator.Play(game);

            score.Should().Be(expectedScore);
        }

        [Test]
        public void ReturnScore_GivenPlayerGetsAStrikeOnTheFirstShot()
        {
            var score = BowlingGameCalculator.Play("X|--|--|--|--|--|--|--|--|--||");

            score.Should().Be(10);
        }

        [Test]
        public void ReturnsScore_GivenPlayerKnocksOnePinInTheSecondShotOfTheFirstFrame()
        {
            var score = BowlingGameCalculator.Play("-1|--|--|--|--|--|--|--|--|--||");

            score.Should().Be(1);
        }

        [Test]
        public void ReturnScore_GivenPlayerKnocksTwoPinsInTheSecondShotOfTheFirstFrame()
        {
            var score = BowlingGameCalculator.Play("-2|--|--|--|--|--|--|--|--|--||");

            score.Should().Be(2);
        }

        [Test]
        public void ReturnsScore_GivenPlayerKnocksThreePinsInTheSecondShotOfTheirFirstFrame()
        {
            var score = BowlingGameCalculator.Play("-3|--|--|--|--|--|--|--|--|--||");

            score.Should().Be(3);
        }
    }
}
