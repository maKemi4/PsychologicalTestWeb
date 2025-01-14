using PsychologicalTestWithBlazor.Components.Services.Abstractions;
using PsychologicalTestWithBlazor.Components.Models;


namespace PsychologicalTestWithBlazor.Components.Services
{
    public class CalculateTotalChoiceValueService : ICalculateTotalChoiceValueService
    {
        public int Calculate(Сhoices choices)
        {
            int totalValue = 0;
            foreach (var question in choices.Questions)
            {
                if (question.SelectedAnswerId.HasValue)
                {
                    var answer = question.Answers.FirstOrDefault(a => a.Id == question.SelectedAnswerId.Value);
                    if (answer != null)
                    {
                        totalValue += answer.ChoiceValue;
                    }
                }
            }

            return totalValue;
        }
    }
}
