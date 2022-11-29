namespace GameAccount
{
    public class GameFactory
    {
        public static BaseGame CreateStandartGame(GameAccount player1, GameAccount player2)
        {
            return new StandartGame();
        }
        public static BaseGame CreateTrainGame(GameAccount player1, GameAccount player2)
        {
            return new TrainGame();
        }
        public static BaseGame CreateOnePlayerPlaysOnRateGame(GameAccount player1, GameAccount player2)
        {
            return new OnePlayerPlaysOnRate();
        }
        public static BaseGame CreateGame5x5(GameAccount player1, GameAccount player2)
        {
            return new Game5x5();
        }
    }
}