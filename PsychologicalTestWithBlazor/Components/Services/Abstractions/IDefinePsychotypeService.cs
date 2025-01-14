using PsychologicalTestWithBlazor.Components.Models;

namespace PsychologicalTestWithBlazor.Components.Services.Abstractions
{
    public interface IDefinePsychotypeService
    {
        PchyhotypeDefinition Define(int totalChoiceValue);
    }
}
