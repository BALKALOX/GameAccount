using System;
using System.ComponentModel;

namespace GameAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var me = new SeriaOfVictoriesGameAccount("cross","zer0",true);
            var oponent = new GameAccount("zer0","cross",false);
            var game1 = GameFactory.CreateOnePlayerPlaysOnRateGame(me,oponent);
            game1.Play(me, oponent);
            var game2 = GameFactory.CreateGame5x5(me, oponent);
            game2.Play(me, oponent);
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