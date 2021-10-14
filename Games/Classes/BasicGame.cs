using System;
using System.Collections.Generic;
using TurtleChallenge.DeployableObjects;
using TurtleChallenge.Factories;
using TurtleChallenge.Moves;
using TurtleChallenge.Validator;
using TurtleChallenge.ValidatorTypes;

namespace TurtleChallenge.Games
{
    public class BasicGame : IGame
    {
        public (int xSize, int ySize) GameBoardSize { get; set; }
        public (int xPosition, int yPosition, string direction) StartingPoint { get; set; }
        public List<IMove> MovesList { get; set; }
        public List<IDeployableObject> DeployableObjectList { get; set; }
        public List<IDeployableObjectsValidator> DeployableObjectsValidatorList { get; set; }
        public List<IPositionValidatorType> PositionValidatorTypeList { get; set; }
        public IGameSettings LoadGameSettings(string[] args)
        {
            string[] gameSettingslines = System.IO.File.ReadAllLines(string.Format(@"D:\git\TurtleChallenge\TurtleChallenge\Files\{0}.txt", args[0]));
            string movesLine = System.IO.File.ReadAllText(string.Format(@"D:\git\TurtleChallenge\TurtleChallenge\Files\{0}.txt", args[1]));

            Dictionary<string, string> gameSettings = new Dictionary<string, string>();
            foreach (string line in gameSettingslines)
                gameSettings.Add(line.Split(':')[0], line.Split(':')[1]);

            var boardSize = gameSettings["BoardSize"].Split('x');
            var startingPoint = gameSettings["StartingPoint"].Split(',');
            var exitPointList = gameSettings["ExitPoint"].Split(';');
            var minesList = gameSettings["Mines"].Split(';');
            var movesList = movesLine.Split(',');

            this.GameBoardSize = (int.Parse(boardSize[0]), int.Parse(boardSize[1]));
            this.StartingPoint = (int.Parse(startingPoint[0]), int.Parse(startingPoint[1]), startingPoint[2]);
            this.DeployableObjectList = new List<IDeployableObject>();
            this.MovesList = new List<IMove>();

            IMovesFactory moveCreator = new MovesFactory();
            foreach (var move in movesList)
                this.MovesList.Add(moveCreator.CreateMove(move));

            foreach (var mineString in minesList)
            {
                var minePosition = mineString.Split(',');
                IDeployableObjectFactory deployableObjectFactory = new DeployableObjectFactory();
                this.DeployableObjectList.Add(deployableObjectFactory.CreateDeployableObject("Mine", int.Parse(minePosition[0]), int.Parse(minePosition[1])));
            }

            foreach (var exitPointString in exitPointList)
            {
                var exitPointPosition = exitPointString.Split(',');
                IDeployableObjectFactory deployableObjectFactory = new DeployableObjectFactory();
                this.DeployableObjectList.Add(deployableObjectFactory.CreateDeployableObject("ExitPoint", int.Parse(exitPointPosition[0]), int.Parse(exitPointPosition[1])));
            }

            this.DeployableObjectsValidatorList = new List<IDeployableObjectsValidator>();
            this.PositionValidatorTypeList = new List<IPositionValidatorType>();

            IDeployableObjectsValidator mineHitValidator = new ValidateMineHit();
            IDeployableObjectsValidator adjacentToMineValidator = new ValidateAdjacentToMine();
            IDeployableObjectsValidator exitPointMineValidator = new ValidateExitPoint();

            this.DeployableObjectsValidatorList.Add(mineHitValidator);
            this.DeployableObjectsValidatorList.Add(adjacentToMineValidator);
            this.DeployableObjectsValidatorList.Add(exitPointMineValidator);

            IPositionValidatorType outOfBoardValidator = new ValidateOutOfBoard();
            this.PositionValidatorTypeList.Add(outOfBoardValidator);

            return this;
        }
        public void ExecuteGame(IGameSettings game)
        {
            (int xPosition, int yPosition, string direction) currentPosition = StartingPoint;

            IMoveValidatorFactory validatorFactory = new MoveValidatorFactory();
            IMoveValidator moveValidator = validatorFactory.CreateValidator();
          
            foreach (var move in game.MovesList)
            {
                currentPosition = move.SetMove(currentPosition);
                string resultMessage = moveValidator.SetValidator(game, currentPosition);
                Console.WriteLine(resultMessage);
            }
        }
    }
}
