namespace GameAccount
{
    public class GameAccount
    {
        public string userName;
        public string oponentName;
        public int currentRating;
        public int gameCount;
        public int num;
        public List<string> list;

        public GameAccount(string userName, string oponentName)
        {
            this.oponentName = oponentName;
            this.userName = userName;
            this.currentRating = 0;
            this.gameCount = 0;
            this.list = new List<string>();
        }
        public void GameWin(int currentRating, int gameCount)
        {
            this.currentRating += 10;
            this.gameCount++;
        }
        public void GameWinPrint(string oponentName, int currentRating)
        {
            Console.WriteLine("!_!_!VICTORY!_!_!");
            Console.WriteLine(oponentName + " lost\n Your rate " + this.currentRating);
        }
        public void GameLoose(int currentRating, int gameCount)
        {
            
            if (currentRating <= 0) { currentRating = 0; }
            else { this.currentRating -= 10; }
            this.gameCount++;
        }
        public void GameLoosePrint(string oponentName, int currentRating)
        {
            Console.WriteLine("._._.WASTED!_._.");
            Console.WriteLine(oponentName + " won\n Your rate " + this.currentRating);
        }
        public string toString(string userName, string oponentName, string currentRating, string gameCount)
        {
            return ("UserName:"+ userName + "\nOponentName :"+ oponentName + "\nRate :" + currentRating + "\nGame :" + gameCount);
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