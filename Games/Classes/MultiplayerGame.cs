using System.Collections.Generic;
using TurtleChallenge.DeployableObjects;
using TurtleChallenge.Moves;
using TurtleChallenge.ValidatorTypes;

namespace TurtleChallenge.Games
{
    public class MultiplayerGame : IGame
    {
        public (int xSize, int ySize) GameBoardSize { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public (int xPosition, int yPosition, string direction) StartingPoint { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public (int xPosition, int yPosition) ExitPoint { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public List<IMove> MovesList { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public List<IDeployableObject> DeployableObjectList { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public List<IDeployableObjectsValidator> DeployableObjectsValidatorList { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public List<IPositionValidatorType> PositionValidatorTypeList { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void ExecuteGame(IGameSettings game)
        {
            throw new System.NotImplementedException();
        }

        public IGameSettings LoadGameSettings(string[] args)
        {
            throw new System.NotImplementedException();
        }
    }
}
