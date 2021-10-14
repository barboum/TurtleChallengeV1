using TurtleChallenge.Validator;

namespace TurtleChallenge.Factories
{
    public class MoveValidatorFactory : IMoveValidatorFactory
    {
        public IMoveValidator CreateValidator()
        {
            IMoveValidator validator = new MoveValidator();
            return validator;
        }
    }
}
