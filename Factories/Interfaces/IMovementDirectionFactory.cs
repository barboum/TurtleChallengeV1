using TurtleChallenge.MoveDirection;

namespace TurtleChallenge.Factories
{
    public interface IMovementDirectionFactory
    {
        IMovementDirection CreateMovementDirection(string movementType);
    }
}
