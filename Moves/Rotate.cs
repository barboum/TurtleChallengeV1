using System.Collections.Generic;
using TurtleChallenge.Factories;
using TurtleChallenge.MoveDirection;

namespace TurtleChallenge.Moves
{
    public class Rotate : IMove
    {
        public (int xPosition, int yPosition, string direction) SetMove((int xPosition, int yPosition, string direction) currentPosition)
        {
            IRotateDirectionFactory moveDirectionFactory = new RotateDirectionFactory();
            IRotateDirection rotateDirection = moveDirectionFactory.CreateRotationDirection(currentPosition.direction);
            return rotateDirection.ExecuteRotation(currentPosition);
        }
    }
}
