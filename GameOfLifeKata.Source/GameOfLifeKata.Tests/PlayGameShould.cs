using FluentAssertions;
using GameOfLifeKata.Source;
using NUnit.Framework;

namespace GameOfLifeKata.Tests
{
    [TestFixture]
    class PlayGameShould
    {
        [Test]
        public void ReturnAllDeadCells_WhenTicking_GivenSeedOfAllDeadCells()
        {
            Cell[] seedOfAllDeadCells = {
                new Cell(Alive: false)
            };
            var cells = new Cells(seedOfAllDeadCells);

            Game.Play(cells);

            cells.AreAllDead().Should().Be(true);
        }

        [Test]
        public void ReturnSomeAliveCells_WhenTicking_GivenSeedOfOneAliveCell()
        {
            Cell[] seedOfOneAliveCells =
            {
                new Cell(Alive: true),
                new Cell(Alive: true),
                new Cell(Alive: true)
            };
            var cells = new Cells(seedOfOneAliveCells);

            Game.Play(cells);

            cells.AreAllDead().Should().Be(false);
        }
    }
}
