using System.Collections.Generic;
using TurtleChallenge.DeployableObjects;
using TurtleChallenge.Generics;

namespace TurtleChallenge.ValidatorTypes
{
    public class ValidateAdjacentToMine : IDeployableObjectsValidator
    {
        public string ExecuteValidation(List<IDeployableObject> deployableObjectList, (int xPosition, int yPosition, string direction) currentPosition)
        {
            string messageResult = string.Empty;

            foreach (var deployableObject in deployableObjectList)
            {
                if (deployableObject is Mine mine)
                {
                    if(currentPosition.yPosition == mine.yPosition && currentPosition.xPosition + 1 == mine.xPosition 
                        || currentPosition.yPosition == mine.yPosition && currentPosition.xPosition -1 == mine.xPosition
                        || currentPosition.xPosition == mine.xPosition && currentPosition.yPosition + 1 == mine.yPosition
                        || currentPosition.xPosition == mine.xPosition && currentPosition.yPosition - 1 == mine.yPosition)
                    {
                        return Constants.ADJACENT_MINE;
                    }
                }
            }

            return messageResult;
        }
    }
}
