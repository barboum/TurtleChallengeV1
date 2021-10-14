using TurtleChallenge.Factories;
using TurtleChallenge.MoveDirection;

namespace TurtleChallenge.Moves
{
    public class Movement : IMove
    {
        public (int xPosition, int yPosition, string direction) SetMove((int xPosition, int yPosition, string direction) currentPosition)
        {
            IMovementDirectionFactory moveDirectionFactory = new MovementDirectionFactory();
            IMovementDirection movementDirection = moveDirectionFactory.CreateMovementDirection(currentPosition.direction);
            return movementDirection.ExecuteMovement(currentPosition);
        }
    }
}
