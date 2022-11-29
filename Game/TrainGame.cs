namespace GameAccount
{
    public class TrainGame:StandartGame
    {
        public override void Win(GameAccount me,GameAccount oponent)
        {
            Console.WriteLine("!_!_!VICTORY!_!_!");
        }
        public override void Loose(GameAccount me, GameAccount oponent)
        {
            Console.WriteLine("._._.WASTED!_._.");
        }
    }
}