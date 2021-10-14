namespace TurtleChallenge.MoveDirection
{
    public class RotateSouth : IRotateDirection
    {
        public (int xPosition, int yPosition, string direction) ExecuteRotation((int xPosition, int yPosition, string direction) currentPosition)
        {
            currentPosition.direction = "South";
            return currentPosition;
        }
    }
}
