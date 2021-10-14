using TurtleChallenge.Games;

namespace TurtleChallenge.Validator
{
    public interface IMoveValidator
    {
        string SetValidator(IGameSettings game, (int xPosition, int yPosition, string direction) currentPosition);
    }
}
