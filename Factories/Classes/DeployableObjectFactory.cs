using TurtleChallenge.DeployableObjects;

namespace TurtleChallenge.Factories
{
    public class DeployableObjectFactory : IDeployableObjectFactory
    {
        public IDeployableObject CreateDeployableObject(string deployableObjectType, int xPosition, int yPosition)
        {
            IDeployableObject deployableObject = null;

            switch (deployableObjectType)
            {
                case "Mine":
                    deployableObject = new Mine(xPosition, yPosition);
                    break;
                case "ExitPoint":
                    deployableObject = new ExitPoint(xPosition, yPosition);
                    break;
                case "Fruit":
                    deployableObject = new Fruit(xPosition, yPosition);
                    break;
                default:
                    break;
            }

            return deployableObject;
        }
    }
}
