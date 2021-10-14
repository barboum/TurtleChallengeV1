using System;
using TurtleChallenge.Games;
using TurtleChallenge.ValidatorTypes;

namespace TurtleChallenge.Validator
{
    public class MoveValidator : IMoveValidator
    {
        public string SetValidator(IGameSettings game, (int xPosition, int yPosition, string direction) currentPosition)
        {
            string messageResult = string.Empty;

            foreach (var positionValidatorType in game.PositionValidatorTypeList)
                messageResult += positionValidatorType.ExecuteValidation(game.GameBoardSize, currentPosition);

            foreach (var deployableObjectsValidator in game.DeployableObjectsValidatorList)
                messageResult += deployableObjectsValidator.ExecuteValidation(game.DeployableObjectList, currentPosition);

            if (string.IsNullOrEmpty(messageResult))
                messageResult = "Success";

            return messageResult;
        }
    }
}
