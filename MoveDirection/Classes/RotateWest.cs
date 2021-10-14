namespace TurtleChallenge.MoveDirection
{
    public class RotateWest : IRotateDirection
    {
        public (int xPosition, int yPosition, string direction) ExecuteRotation((int xPosition, int yPosition, string direction) currentPosition)
        {
            currentPosition.direction = "West";
            return currentPosition;
        }
     }
}
