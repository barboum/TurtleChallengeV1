using TurtleChallenge.MoveDirection;

namespace TurtleChallenge.Factories
{
    public class MovementDirectionFactory : IMovementDirectionFactory
    {
        public IMovementDirection CreateMovementDirection(string movementDirection)
        {
            IMovementDirection moveType = null;

            switch (movementDirection)
            {
                case "North":
                    moveType = new MovementNorth();
                    break;
                case "East":
                    moveType = new MovementEast();
                    break;
                case "South":
                    moveType = new MovementSouth();
                    break;
                case "West":
                    moveType = new MovementWest();
                    break;
                default:
                    break;
            }

            return moveType;
        }
    }
}
