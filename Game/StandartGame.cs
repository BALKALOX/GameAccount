using System.ComponentModel;

namespace GameAccount
{
    public class StandartGame : BaseGame
    {
        public override void Play(GameAccount me, GameAccount oponent)
        {
            Random rnd = new Random();
            me.num = rnd.Next();
            oponent.num = rnd.Next();
            if (me.num > oponent.num)
                Win(me, oponent);
            else 
                Loose(me, oponent);
            ListAdd(me, oponent);
            string action = Console.ReadLine();
            if (action.Length == 0)
                Console.WriteLine("The end of the game \nYour score\nRating :" + me.currentRating + "\nGames played :" + me.gameCount);
            else
                Play(me, oponent);
        }
        public static void Win(GameAccount me, GameAccount oponent)
        {
            me.GameWin(me.currentRating, me.gameCount);
            me.GameWinPrint(me.oponentName, me.currentRating);
            oponent.GameLoose(oponent.currentRating, oponent.gameCount);
        }
        public static void Loose(GameAccount me, GameAccount oponent)
        {
            me.GameLoose(me.currentRating, me.gameCount);
            me.GameLoosePrint(me.oponentName, me.currentRating);
            oponent.GameWin(oponent.currentRating, oponent.gameCount);
        }
        public static void ListAdd(GameAccount me, GameAccount oponent)
        {
            me.list.Add(me.toString(me.userName, me.oponentName, me.currentRating.ToString(), me.gameCount.ToString()));
            oponent.list.Add(oponent.toString(oponent.userName, oponent.oponentName, oponent.currentRating.ToString(), oponent.gameCount.ToString()));
        }
    }
}