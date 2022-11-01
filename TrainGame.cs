namespace GameAccount
{
    public class TrainGame:BaseGame
    {
        public static void Gamee(GameAccount me, GameAccount oponent)
        {
            Random rnd = new Random();
            me.num = rnd.Next();
            oponent.num = rnd.Next();
            if (me.num > oponent.num)
                Win(me, oponent);
            else
                Loose(me, oponent);
            //ListAdd(me, oponent);
            string action = Console.ReadLine();
            if (action.Length == 0)
                Console.WriteLine("The end of the game \nYour score\nRating :" + me.CurrentRating + "\nGames played :" + me.GameCount);
            else
                Gamee(me, oponent);
        }
        public static void Win(GameAccount me,GameAccount oponent)
        {
            Console.WriteLine("!_!_!VICTORY!_!_!");
        }
        public static void Loose(GameAccount me, GameAccount oponent)
        {
            Console.WriteLine("._._.WASTED!_._.");
        }
    }
}