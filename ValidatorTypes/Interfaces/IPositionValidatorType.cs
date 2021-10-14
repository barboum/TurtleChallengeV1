using TurtleChallenge.Games;

namespace TurtleChallenge.ValidatorTypes
{
    public interface IPositionValidatorType
    {
        string ExecuteValidation((int xPosition, int yPosition) position, (int xPosition, int yPosition, string direction) currentPosition);
    }
}
