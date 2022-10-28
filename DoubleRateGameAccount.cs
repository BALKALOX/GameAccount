namespace GameAccount
{
    public class DoubleRateGameAccount : GameAccount
    {
        public DoubleRateGameAccount(string UN, string ON) : base(UN, ON)
        {
            this.OponentName = ON;
            this.UserName = UN;
            this.CurrentRating = 0;
            this.GameCount = 0;
            this.list = new List<string>();
        }

        public override void GameWin(int CurrentRating, int GameCount, string OponentName)
        {
            this.CurrentRating += 20;
            this.GameCount++;
        }
    }
}