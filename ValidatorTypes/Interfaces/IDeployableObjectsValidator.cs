using System.Collections.Generic;
using TurtleChallenge.DeployableObjects;

namespace TurtleChallenge.ValidatorTypes
{
    public interface IDeployableObjectsValidator
    {
        string ExecuteValidation(List<IDeployableObject> deployableObjectList, (int xPosition, int yPosition, string direction) currentPosition);
    }
}
