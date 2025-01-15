namespace PsychologicalTestWithBlazor.Models
{
    public class ScoreRange
    {
        public int Min { get; set; }
        public int Max { get; set; }

        public ScoreRange(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public bool IsWithinRange(int score) => score >= Min && score <= Max;
    }
}
