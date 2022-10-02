namespace GameAccount
{
    public class Game
    {
        public static void Game(GameAccount me, GameAccount oponent)
        {
            Random rnd = new Random();
            me.num = rnd.Next();
            oponent.num = rnd.Next();
            if (me.num > oponent.num)
            {
                me.GameWin(me.CurrentRating, me.GameCount, me.OponentName);
            }
            else
            {
                me.GameLoose(me.CurrentRating, me.GameCount, me.OponentName);
            }
            me.list.Add(me.toString(me.UserName, me.OponentName, me.CurrentRating.ToString(), me.GameCount.ToString()));
            string action = Console.ReadLine();
            if (action.Length == 0)
            {
                Console.WriteLine("The end of the game \nYour score\nRating :" + me.CurrentRating + "\nGames played :" + me.GameCount);
            }
            else
            {
                Game(me, oponent);
            }

        }
    }
   
}