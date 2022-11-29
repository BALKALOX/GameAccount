namespace GameAccount
{
    public class DoubleRateGameAccount : GameAccount
    {
        public DoubleRateGameAccount(string userName, string oponentName, bool b) : base(userName, oponentName,b)
        {
            this.oponentName = oponentName;
            this.userName = userName;
            this.currentRating = 0;
            this.gameCount = 0;
            this.list = new List<string>();
            if (b)
                this.role = 'x';
            else this.role = '0';
        }

        public override void GameWin(int currentRating, int gameCount)
        {
            this.currentRating += 20;
            this.gameCount++;
        }
    }
}