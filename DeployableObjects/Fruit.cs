namespace TurtleChallenge.DeployableObjects
{
    public class Fruit : IDeployableObject
    {
        public int xPosition { get; set; }
        public int yPosition { get; set; }

        public Fruit(int _xPostion, int _yPosition)
        {
            this.xPosition = _xPostion;
            this.yPosition = _yPosition;
        }
    }
}
