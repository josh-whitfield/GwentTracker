namespace GwentTracker
{
    public class CurrentScores
    {
        public CurrentScores()
        {
            PlayerOneTotal = 0;
            PlayerOneMeleeTotal = 0;
            PlayerOneRangeTotal = 0;
            PlayerOneSiegeTotal = 0;
            PlayerTwoTotal = 0;
            PlayerTwoMeleeTotal = 0;
            PlayerTwoRangeTotal = 0;
            PlayerTwoSiegeTotal = 0;
        }

        public int PlayerOneTotal { get; set; }
        public int PlayerOneMeleeTotal { get; set; }
        public int PlayerOneRangeTotal { get; set; }
        public int PlayerOneSiegeTotal { get; set; }
        public int PlayerTwoTotal { get; set; }
        public int PlayerTwoMeleeTotal { get; set; }
        public int PlayerTwoRangeTotal { get; set; }
        public int PlayerTwoSiegeTotal { get; set; }
    }
}