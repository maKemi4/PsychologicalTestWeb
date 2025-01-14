using PsychologicalTestWithBlazor.Components.Models;
using PsychologicalTestWithBlazor.Components.Services.Abstractions;

namespace PsychologicalTestWithBlazor.Components.Services
{
    public class DefinePsychotypeService : IDefinePsychotypeService
    {
        public PchyhotypeDefinition Define(int totalChoiceValue)
        {
            var psychotypes = Psychotypes.Get();
            var descriptions = PsychotypesInfo.Get();
            var definition = new PchyhotypeDefinition();

            foreach (var psychotypeEntry in psychotypes)
            {
                if (psychotypeEntry.Value.IsWithinRange(totalChoiceValue))
                {
                    definition.psychotype = psychotypeEntry.Key;
                    break;
                }
            }

            if (definition.psychotype != null && descriptions.TryGetValue(definition.psychotype, out var description))
            {
                definition.psychotypeDescription = description;
            }

            if (!string.IsNullOrEmpty(definition.psychotypeDescription))
            {
                var splitIndex = definition.psychotypeDescription.IndexOf("Recommendations:");
                if (splitIndex != -1)
                {
                    definition.info = definition.psychotypeDescription.Substring(0, splitIndex).Trim();
                    definition.recommendations = definition.psychotypeDescription.Substring(splitIndex + "Recommendations:".Length).Trim();
                }
                else
                {
                    definition.info = definition.psychotypeDescription;
                }
            }

            return definition;
        }
    }
}
