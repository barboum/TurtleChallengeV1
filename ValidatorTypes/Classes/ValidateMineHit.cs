using System.Collections.Generic;
using TurtleChallenge.DeployableObjects;
using TurtleChallenge.Generics;

namespace TurtleChallenge.ValidatorTypes
{
    public class ValidateMineHit : IDeployableObjectsValidator
    {
        public string ExecuteValidation(List<IDeployableObject> deployableObjectList, (int xPosition, int yPosition, string direction) currentPosition)
        {
            foreach (var deployableObject in deployableObjectList)
            {
                if(deployableObject is Mine mine)
                {
                    if (mine.xPosition == currentPosition.xPosition && mine.yPosition == currentPosition.yPosition)
                        return Constants.MINE_HIT;
                }
            }

            return string.Empty;
        }
    }
}
