namespace GameOfLifeKata.Source
{
    public class Cells
    {
        private readonly Cell[] _seed;

        public Cells(Cell[] seed)
        {
            _seed = seed;
        }

        public bool AreAllDead()
        {
            if (_seed.Length > 1)
            {
                return false;
            }

            return true;
        }
    }
}