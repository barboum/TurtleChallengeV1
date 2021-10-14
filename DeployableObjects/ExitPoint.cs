namespace TurtleChallenge.DeployableObjects
{
    public class ExitPoint : IDeployableObject
    {
        public int xPosition { get; set; }
        public int yPosition { get; set; }

        public ExitPoint(int _xPostion, int _yPosition)
        {
            this.xPosition = _xPostion;
            this.yPosition = _yPosition;
        }
    }
}
