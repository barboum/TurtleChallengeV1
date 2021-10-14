namespace TurtleChallenge.MoveDirection
{
    public interface IMovementDirection
    {
        (int xPosition, int yPosition, string direction) ExecuteMovement((int xPosition, int yPosition, string direction) currentPosition);
    }
}
