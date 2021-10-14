namespace TurtleChallenge.MoveDirection
{
    public interface IRotateDirection
    {
        (int xPosition, int yPosition, string direction) ExecuteRotation((int xPosition, int yPosition, string direction) currentPosition);
    }
}
