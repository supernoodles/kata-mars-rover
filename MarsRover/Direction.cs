namespace MarsRover
{
    using System.Collections.Generic;

    public class Direction
    {
        enum CompassEnum { N, E, S, W };

        readonly CompassEnum currentDirection;

        public static readonly Direction North;
        public static readonly Direction East;
        public static readonly Direction South;
        public static readonly Direction West;

        static readonly IList<Direction> Directions;

        static Direction()
        {
            North = new Direction(CompassEnum.N);
            East = new Direction(CompassEnum.E);
            South = new Direction(CompassEnum.S);
            West = new Direction(CompassEnum.W);
            Directions = new List<Direction> {North, East, South, West};
        }

        private Direction(CompassEnum direction)
        {
            currentDirection = direction;
        }

        public Direction TurnLeft()
        {
            return Directions[(4 + Directions.IndexOf(this) - 1) % 4];
        }

        public Direction TurnRight()
        {
            return Directions[(4 + Directions.IndexOf(this) + 1) % 4];
        }

        public override string ToString()
        {
            return currentDirection.ToString();
        }
    }
}