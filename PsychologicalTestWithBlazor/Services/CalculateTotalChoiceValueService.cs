using PsychologicalTestWithBlazor.Models;
using PsychologicalTestWithBlazor.Services.Abstractions;


namespace PsychologicalTestWithBlazor.Services
{
    public class CalculateTotalChoiceValueService : ICalculateTotalChoiceValueService
    {
        public int Calculate(Сhoices choices)
        {
            int _totalValue = 0;
            foreach (var _question in choices.Questions)
            {
                if (_question.SelectedAnswerId.HasValue)
                {
                    var _answer = _question.Answers.FirstOrDefault(a => a.Id == _question.SelectedAnswerId.Value);
                    if (_answer != null)
                    {
                        _totalValue += _answer.ChoiceValue;
                    }
                }
            }

            return _totalValue;
        }
    }
}
