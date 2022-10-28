namespace GameAccount
{
    public class SeriaOfVictoriesGameAccount : GameAccount
    {
        private int seriaOfVictories;
        public SeriaOfVictoriesGameAccount(string UN, string ON) : base(UN, ON)
        {
            this.seriaOfVictories = 0;
            this.OponentName = ON;
            this.UserName = UN;
            this.CurrentRating = 0;
            this.GameCount = 0;
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
        public override void GameWin(int CurrentRating, int GameCount, string OponentName)
        {
            IncreaseSeriaOfVictories();
            if (seriaOfVictories > 1)
            {
                this.CurrentRating += seriaOfVictories * 2;
            }
            this.CurrentRating += 10 ;
            this.GameCount++;
        }
        public override void GameLoose(int CurrentRating, int GameCount, string OponentName)
        {
            NullSeriaOfVictories();
            if (CurrentRating-10 <= 0) { this.CurrentRating = 0; }
            else { this.CurrentRating -= 10; }
            this.GameCount++;
        }
    }
}