namespace TurtleChallenge.DeployableObjects
{
    public class Mine : IDeployableObject
    {
        public int xPosition { get; set; }
        public int yPosition { get; set; }

        public Mine(int _xPostion, int _yPosition)
        {
            this.xPosition = _xPostion;
            this.yPosition = _yPosition;
        }
    }
}
