using TurtleChallenge.DeployableObjects;

namespace TurtleChallenge.Factories
{
    public interface IDeployableObjectFactory
    {
        IDeployableObject CreateDeployableObject(string movementType, int xPosition, int yPosition);
    }
}
