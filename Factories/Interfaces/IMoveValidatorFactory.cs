using TurtleChallenge.Validator;

namespace TurtleChallenge.Factories
{
    public interface IMoveValidatorFactory
    {
        IMoveValidator CreateValidator();
    }
}
