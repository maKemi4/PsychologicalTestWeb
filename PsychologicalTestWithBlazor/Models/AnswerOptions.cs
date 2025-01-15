namespace PsychologicalTestWithBlazor.Models
{
    public static class AnswerOptions
    {
        public static Dictionary<string, int> Get()
        {
            return new Dictionary<string, int>()
            {
                {"Extremely rarely or never", 1},
                {"Sometimes", 2},
                {"Most of the time", 3},
                {"Almost all the time", 4}
            };
        }
    }
}
