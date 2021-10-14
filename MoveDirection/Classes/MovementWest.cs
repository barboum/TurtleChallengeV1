namespace TurtleChallenge.MoveDirection
{
    public class MovementWest : IMovementDirection
    {
        public (int xPosition, int yPosition, string direction) ExecuteMovement((int xPosition, int yPosition, string direction) currentPosition)
        {
            currentPosition.xPosition--;
            return currentPosition;
        }
     }
}
