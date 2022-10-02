using System.ComponentModel;

namespace GameAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var me = new GameAccount("me","oponent");
            var oponent = new GameAccount("oponent","me");
            Game.Game( me,  oponent);
            Console.WriteLine("\nTo show all games stats enter something\nTo skip press ENTER\n");
            GameAccount.ShowStats(me.list);
            GameAccount.ShowStats(me.list);
            string irr = Console.ReadLine();
            if (irr.Length > 0)
            {
                GameAccount.ShowStats(me.list);
            }

        } 
        
        
    }
   
}