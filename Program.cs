using System.ComponentModel;

namespace GameAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var me = new GameAccount("me","oponent");
            var oponent = new GameAccount("oponent","me");
            Game( me,  oponent);
            Console.WriteLine("\nTo show all games stats enter something\nTo skip press ENTER\n");
            string i = Console.ReadLine();
            if (i.Length > 0)
            {
                ShowStats(me.list);
            }
        } 
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
                Console.WriteLine("The end of the game \nYour score\nRating :"+me.CurrentRating +"\nGames played :"+me.GameCount);
            }
            else
            {
                Game(me, oponent);
            }
           
        }
        public static void ShowStats(List<string> list)
        {
            Console.WriteLine("All  games stats:\n");
            foreach (string item in list)
            {
                Console.WriteLine(item+"\n");

            }
        }
    }
   
}