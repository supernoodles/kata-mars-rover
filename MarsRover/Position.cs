namespace MarsRover
{
    public class Position
    {
        readonly int x;
        readonly int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Position MoveNorth(int bound)
        {
            return new Position(x, (bound + y + 1) % bound);
        }

        public Position MoveEast(int bound)
        {
            return new Position((bound + x + 1) % bound, y);
        }

        public Position MoveSouth(int bound)
        {
            return new Position(x, (bound + y - 1) % bound);
        }

        public Position MoveWest(int bound)
        {
            return new Position((bound + x - 1) % bound, y);
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", x, y);
        }
    }
}
