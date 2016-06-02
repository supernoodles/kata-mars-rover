namespace MarsRover
{
    public class MarsSurface
    {
        readonly int width;
        readonly int height;

        Position position;

        public MarsSurface(int width, int height, Position initialPosition)
        {
            this.width = width;
            this.height = height;
            position = initialPosition;
        }

        public void MoveRover(Direction direction)
        {
            if (direction.Equals(Direction.North))
            {
                position = position.MoveNorth(height);
            }
            if (direction.Equals(Direction.East))
            {
                position = position.MoveEast(width);
            }
            if (direction.Equals(Direction.South))
            {
                position = position.MoveSouth(height);
            }
            if (direction.Equals(Direction.West))
            {
                position = position.MoveWest(width);
            }
        }

        public override string ToString()
        {
            return position.ToString();
        }
    }
}