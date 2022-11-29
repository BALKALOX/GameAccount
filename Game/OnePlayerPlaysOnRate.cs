namespace GameAccount
{
    public class OnePlayerPlaysOnRate : StandartGame
    {
        public override void Win(GameAccount cross, GameAccount zero)
        {
            cross.GameWin(cross.currentRating, cross.gameCount);
            cross.GameWinPrint(cross.oponentName, cross.currentRating);
            ListAdd(cross, zero);
        }
        public override void Loose(GameAccount cross, GameAccount zero)
        {
            cross.GameLoose(cross.currentRating, cross.gameCount);
            cross.GameLoosePrint(cross.oponentName, cross.currentRating);
            ListAdd(cross, zero);
        }
    }
}