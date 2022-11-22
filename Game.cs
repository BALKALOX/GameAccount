namespace GameAccount
{
    public class Game
    {
        public static void Gamee(GameAccount me, GameAccount oponent)
        {
            Random rnd = new Random();
            me.num = rnd.Next();
            oponent.num = rnd.Next();
            if (me.num > oponent.num)
            {
                me.GameWin(me.currentRating, me.gameCount);
                me.GameWinPrint(me.oponentName, me.currentRating);
                oponent.GameLoose(oponent.currentRating, oponent.gameCount);
            }
            else
            {
                me.GameLoose(me.currentRating, me.gameCount);
                me.GameLoosePrint(me.oponentName, me.currentRating);
                oponent.GameWin(oponent.currentRating, oponent.gameCount);
            }
            me.list.Add(me.toString(me.userName, me.oponentName, me.currentRating.ToString(), me.gameCount.ToString()));
            oponent.list.Add(oponent.toString(oponent.userName, oponent.oponentName, oponent.currentRating.ToString(), oponent.gameCount.ToString()));
            string action = Console.ReadLine();
            if (action.Length == 0)
            {
                Console.WriteLine("The end of the game \nYour score\nRating :" + me.currentRating + "\nGames played :" + me.gameCount);
            }
            else
            {
                Gamee(me, oponent);
            }

        }
    }
   
}