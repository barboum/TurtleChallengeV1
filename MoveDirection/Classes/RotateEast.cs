namespace TurtleChallenge.MoveDirection
{
    public class RotateEast : IRotateDirection
    {
        public (int xPosition, int yPosition, string direction) ExecuteRotation((int xPosition, int yPosition, string direction) currentPosition)
        {
            currentPosition.direction = "East";
            return currentPosition;
        }
    }
}
