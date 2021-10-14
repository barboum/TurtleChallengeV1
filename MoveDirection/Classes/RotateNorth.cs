namespace TurtleChallenge.MoveDirection
{
    public class RotateNorth : IRotateDirection
    {
        public (int xPosition, int yPosition, string direction) ExecuteRotation((int xPosition, int yPosition, string direction) currentPosition)
        {
            currentPosition.direction = "North";
            return currentPosition;
        }
    }
}
