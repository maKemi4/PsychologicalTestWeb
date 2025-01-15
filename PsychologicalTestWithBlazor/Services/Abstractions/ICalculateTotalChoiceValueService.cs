using PsychologicalTestWithBlazor.Models;

namespace PsychologicalTestWithBlazor.Services.Abstractions
{
    public interface ICalculateTotalChoiceValueService
    {
        int Calculate(Сhoices Choices);
    }
}
