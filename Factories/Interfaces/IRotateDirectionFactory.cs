using TurtleChallenge.MoveDirection;

namespace TurtleChallenge.Factories
{
    public interface IRotateDirectionFactory
    {
        IRotateDirection CreateRotationDirection(string rotationDirection);

    }
}
