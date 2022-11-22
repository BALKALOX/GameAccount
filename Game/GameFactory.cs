namespace GameAccount
{
    public class GameFactory
    {
        public static StandartGame CreateStandartGame(GameAccount player1, GameAccount player2)
        {
            return new StandartGame();
        }
        public static TrainGame CreateTrainGame(GameAccount player1, GameAccount player2)
        {
            return new TrainGame();
        }
        public static OnePlayerPlaysOnRate CreateOnePlayerPlaysOnRateGame(GameAccount player1, GameAccount player2)
        {
            return new OnePlayerPlaysOnRate();
        }
    }
}