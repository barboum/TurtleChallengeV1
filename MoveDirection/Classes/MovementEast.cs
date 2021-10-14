namespace TurtleChallenge.MoveDirection
{
    public class MovementEast : IMovementDirection
    {
        public (int xPosition, int yPosition, string direction) ExecuteMovement((int xPosition, int yPosition, string direction) currentPosition)
        {
            currentPosition.xPosition++;
            return currentPosition;
        }
    }
}
