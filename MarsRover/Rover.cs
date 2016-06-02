namespace MarsRover
{
    public class Rover
    {
        readonly MarsSurface surface;
        Direction direction = Direction.North;

        public Rover(MarsSurface surface)
        {
            this.surface = surface;
        }

        public void Instruct(string instructions)
        {
            foreach (var instruction in instructions)
            {
                if (instruction == 'M')
                {
                    surface.MoveRover(direction);
                }

                if(instruction == 'L')
                {
                    direction = direction.TurnLeft();
                }

                if (instruction == 'R')
                {
                    direction = direction.TurnRight();
                }
            }
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", surface, direction);
        }
    }
}