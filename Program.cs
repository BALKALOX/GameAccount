using System.ComponentModel;

namespace GameAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var me = new SeriaOfVictoriesGameAccount("me","oponent");
            var oponent = new GameAccount("oponent","me");
            var game = GameFactory.CreateStandartGame(me,oponent);
            game.Play(me, oponent);
            Console.WriteLine("\nTo show all games /" + "/" + "stats enter something\nTo skip press ENTER\n");

            string irr = Console.ReadLine();
            if (irr.Length > 0)
            {
                GameAccount.ShowStats(me.list);
                GameAccount.ShowStats(oponent.list);
            }
        } 
    }
}