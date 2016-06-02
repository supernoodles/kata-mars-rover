namespace MarsRover
{
    using NUnit.Framework;

    [TestFixture]
    class RoverTests
    {
        [TestCase("M","(0,1,N)")]
        [TestCase("MM", "(0,2,N)")]
        [TestCase("MMM", "(0,3,N)")]
        [TestCase("L", "(0,0,W)")]
        [TestCase("R", "(0,0,E)")]
        [TestCase("RM", "(1,0,E)")]
        [TestCase("RL", "(0,0,N)")]
        [TestCase("RLLL", "(0,0,S)")]
        [TestCase("RMLM", "(1,1,N)")]
        [TestCase("LM", "(9,0,W)")]
        [TestCase("MMMMMMMMMM", "(0,0,N)")]
        [TestCase("RMMMMMMMMMM", "(0,0,E)")]
        public void MoveRoverWithInstructions_FromInitialPosition_RoverFinishesInSpecifiedPosition(string instructions, string expectedPosition)
        {
            var rover = new Rover(new MarsSurface(10, 10, new Position(0, 0)));
            rover.Instruct(instructions);

            Assert.That(rover.ToString(), Is.EqualTo(expectedPosition));
        }
    }
}
