namespace TurtleChallenge.Moves
{
    public interface IMove
    {
        (int xPosition, int yPosition, string direction) SetMove((int xPosition, int yPosition, string direction) currentPosition);
    }
}
