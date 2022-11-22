namespace GameAccount
{
    public class SeriaOfVictoriesGameAccount : GameAccount
    {
        private int seriaOfVictories;
        public SeriaOfVictoriesGameAccount(string userName, string oponentName) : base(userName, oponentName)
        {
            this.seriaOfVictories = 0;
            this.oponentName = oponentName;
            this.userName = userName;
            this.currentRating = 0;
            this.gameCount = 0;
            this.list = new List<string>();
        }
        public void IncreaseSeriaOfVictories()
        {
            this.seriaOfVictories ++;
        }
        public void NullSeriaOfVictories()
        {
            this.seriaOfVictories = 0;
        }
        public override void GameWin(int currentRating, int gameCount)
        {
            IncreaseSeriaOfVictories();
            if (seriaOfVictories > 1)
            {
                this.currentRating += seriaOfVictories * 1;
            }
            this.currentRating += 10 ;
            this.gameCount++;
            this.IncreaseSeriaOfVictories();
        }
        public override void GameLoose(int currentRating, int gameCount)
        {
            NullSeriaOfVictories();
            if (currentRating-10 <= 0) { this.currentRating = 0; }
            else { this.currentRating -= 10; }
            this.gameCount++;
        }
    }
}