namespace TurtleChallenge.MoveDirection
{
    public class MovementSouth : IMovementDirection
    {
        public (int xPosition, int yPosition, string direction) ExecuteMovement((int xPosition, int yPosition, string direction) currentPosition)
        {
            currentPosition.yPosition--;
            return currentPosition;
        }
    }
}
