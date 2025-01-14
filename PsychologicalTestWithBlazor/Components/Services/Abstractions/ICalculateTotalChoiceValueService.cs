using PsychologicalTestWithBlazor.Components.Models;

namespace PsychologicalTestWithBlazor.Components.Services.Abstractions
{
    public interface ICalculateTotalChoiceValueService
    {
        int Calculate(Сhoices choices);
    }
}
