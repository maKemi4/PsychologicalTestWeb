namespace PsychologicalTestWithBlazor.Components.Models
{
    public static class Psychotypes
    {
        public static Dictionary<string, ScoreRange> Get()
        {
            return new Dictionary<string, ScoreRange>()
            {
                {"Dysthymia (Persistent Depressive Disorder)", new ScoreRange(1, 19)},
                {"Atypical Depression", new ScoreRange(20, 29) },
                {"Seasonal Affective Disorder", new ScoreRange(30, 39) },
                {"Major Depression (Clinical Depression)", new ScoreRange(40, 49) },
                {"Bipolar Disorder (Manic-Depressive Disorder)", new ScoreRange(50, 59) },
                {"Psychotic Depression", new ScoreRange(60, int.MaxValue) }
            };

            // The second number in the dictionary represents TotalChoiceValue
        }
    }
}
