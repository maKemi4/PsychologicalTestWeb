using PsychologicalTestWithBlazor.Models;

namespace PsychologicalTestWithBlazor.Services.Abstractions
{
    public interface IDefinePsychotypeService
    {
        PchyhotypeDefinition Define(int TotalChoiceValue);
    }
}
