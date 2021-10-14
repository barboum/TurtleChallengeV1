using System.Collections.Generic;
using TurtleChallenge.DeployableObjects;
using TurtleChallenge.Moves;
using TurtleChallenge.ValidatorTypes;

namespace TurtleChallenge.Games
{
    public interface IGameSettings
    {
        public (int xSize, int ySize) GameBoardSize { get; set; }
        public (int xPosition, int yPosition, string direction) StartingPoint { get; set; }
        public List<IMove> MovesList { get; set; }
        public List<IDeployableObject> DeployableObjectList { get; set; }
        public List<IDeployableObjectsValidator> DeployableObjectsValidatorList { get; set; }
        public List<IPositionValidatorType> PositionValidatorTypeList { get; set; }
        public IGameSettings LoadGameSettings(string[] args);
    }
}
