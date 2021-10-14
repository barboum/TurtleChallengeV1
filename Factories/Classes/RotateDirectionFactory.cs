using System.Collections.Generic;
using TurtleChallenge.MoveDirection;

namespace TurtleChallenge.Factories
{
    public class RotateDirectionFactory : IRotateDirectionFactory
    {
        private List<string> directionsList = new List<string>() { "North", "East", "South", "West" };
        public IRotateDirection CreateRotationDirection(string rotationDirection)
        {
            int currentIndex = directionsList.IndexOf(rotationDirection);

            if(currentIndex == directionsList.Count -1)
                rotationDirection = directionsList[0];
            else
            rotationDirection = directionsList[currentIndex + 1];

            IRotateDirection rotationType = null;

            switch (rotationDirection)
            {
                case "North":
                    rotationType = new RotateNorth();
                    break;
                case "East":
                    rotationType = new RotateEast();
                    break;
                case "South":
                    rotationType = new RotateSouth();
                    break;
                case "West":
                    rotationType = new RotateWest();
                    break;
                default:
                    break;
            }

            return rotationType;
        }
    }
}
