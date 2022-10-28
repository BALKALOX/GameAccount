namespace GameAccount
{
    public class OnePlayerPlaysOnRate : Game
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
            ListAdd(me, oponent);
            string action = Console.ReadLine();
            if (action.Length == 0)
                Console.WriteLine("The end of the game \nYour score\nRating :" + me.CurrentRating + "\nGames played :" + me.GameCount);
            else
                Gamee(me, oponent);
        }
        public static void Win(GameAccount me, GameAccount oponent)
        {
            me.GameWin(me.CurrentRating, me.GameCount, me.OponentName);
            me.GameWinPrint(me.OponentName, me.CurrentRating);
        }
        public static void Loose(GameAccount me, GameAccount oponent)
        {
            me.GameLoose(me.CurrentRating, me.GameCount, me.OponentName);
            me.GameLoosePrint(me.OponentName, me.CurrentRating);
        }
        public static void ListAdd(GameAccount me, GameAccount oponent)
        {
            me.list.Add(me.toString(me.UserName, me.OponentName, me.CurrentRating.ToString(), me.GameCount.ToString()));
            oponent.list.Add(oponent.toString(oponent.UserName, oponent.OponentName, oponent.CurrentRating.ToString(), oponent.GameCount.ToString()));
        }
    }
}