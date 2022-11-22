namespace GameAccount
{
    public class DoubleRateGameAccount : GameAccount
    {
        public DoubleRateGameAccount(string userName, string oponentName) : base(userName, oponentName)
        {
            this.oponentName = oponentName;
            this.userName = userName;
            this.currentRating = 0;
            this.gameCount = 0;
            this.list = new List<string>();
        }

        public override void GameWin(int currentRating, int gameCount)
        {
            this.currentRating += 20;
            this.gameCount++;
        }
    }
}