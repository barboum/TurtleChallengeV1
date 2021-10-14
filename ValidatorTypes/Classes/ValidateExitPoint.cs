using System.Collections.Generic;
using TurtleChallenge.DeployableObjects;
using TurtleChallenge.Generics;

namespace TurtleChallenge.ValidatorTypes
{
    public class ValidateExitPoint : IDeployableObjectsValidator
    {
        public string ExecuteValidation(List<IDeployableObject> deployableObjectList, (int xPosition, int yPosition, string direction) currentPosition)
        {
            foreach (var deployableObject in deployableObjectList)
            {
                if (deployableObject is ExitPoint exitPoint)
                {
                    if (exitPoint.xPosition == currentPosition.xPosition && exitPoint.yPosition == currentPosition.yPosition)
                        return Constants.EXIT_POINT_ACHIEVED;
                }
            }

            return string.Empty;
        }
    }
}
