using System;
using TurtleChallenge.Games;
using TurtleChallenge.Generics;

namespace TurtleChallenge.ValidatorTypes
{
    public class ValidateOutOfBoard : IPositionValidatorType
    {
        public string ExecuteValidation((int xPosition, int yPosition) boardSize, (int xPosition, int yPosition, string direction) currentPosition)
        {
            string messageResult = string.Empty;

            if(currentPosition.xPosition > boardSize.xPosition
                || currentPosition.xPosition < 0
                || currentPosition.yPosition > boardSize.yPosition
                || currentPosition.yPosition < 0)
            {
                return Constants.OUT_OF_THE_BOARD;
            }

            return messageResult;
        }
    }
}
