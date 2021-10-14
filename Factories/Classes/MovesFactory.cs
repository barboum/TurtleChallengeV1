using TurtleChallenge.Moves;

namespace TurtleChallenge.Factories
{
    public class MovesFactory : IMovesFactory
    {
        public IMove CreateMove(string movementType)
        {
            IMove move = null;

            switch (movementType)
            {
                case "m":
                    move = new Movement();
                    break;
                case "r":
                    move = new Rotate();
                    break;
                default:
                    break;
            }

            return move;
        }
    }
}
