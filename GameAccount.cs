namespace GameAccount
{
    public class GameAccount
    {
        public string UserName;
        public string OponentName;
        public int CurrentRating;
        public int GameCount;
        public int num;
        public List<string> list;

        public GameAccount(string UN, string ON)
        {
            this.OponentName = ON;
            this.UserName = UN;
            this.CurrentRating = 0;
            this.GameCount = 0;
            this.list = new List<string>();
        }
        public void GameWin(int CurrentRating, int GameCount, string OponentName)
        {
            Console.WriteLine("!_!_!VICTORY!_!_!");
            this.CurrentRating += 10;
            Console.WriteLine(OponentName+" lost\n Your rate " + this.CurrentRating);
            this.GameCount++;
        }
        public void GameLoose(int CurrentRating, int GameCount, string OponentName)
        {
            Console.WriteLine("._._.WASTED!_._.");
            if (CurrentRating <= 0) { CurrentRating = 0; }
            else { this.CurrentRating -= 10; }
            Console.WriteLine(OponentName + " won\n Your rate " + this.CurrentRating);
            this.GameCount++;
        }
        public string toString(string UN, string ON, string CR, string GC)
        {
            return ("UserName:"+UN+"\nOponentName :"+ON+ "\nRate :" + CR + "\nGame :" + GC);
        }
        public static void ShowStats(List<string> list)
        {
            Console.WriteLine("All  games stats:\n");
            foreach (string item in list)
            {
                Console.WriteLine(item + "\n");

            }
        }
    }
}