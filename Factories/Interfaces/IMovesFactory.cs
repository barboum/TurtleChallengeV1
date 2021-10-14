using TurtleChallenge.Moves;

namespace TurtleChallenge.Factories
{
    public interface IMovesFactory
    {
        IMove CreateMove(string movementType);
    }
}
