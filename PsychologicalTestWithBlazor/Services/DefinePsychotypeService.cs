using PsychologicalTestWithBlazor.Models;
using PsychologicalTestWithBlazor.Services.Abstractions;

namespace PsychologicalTestWithBlazor.Services
{
    public class DefinePsychotypeService : IDefinePsychotypeService
    {
        public PchyhotypeDefinition Define(int totalChoiceValue)
        {
            var _psychotypes = Models.Psychotypes.Get();
            var _descriptions = PsychotypesInfo.Get();
            var _definition = new PchyhotypeDefinition();

            foreach (var _psychotypeEntry in _psychotypes)
            {
                if (_psychotypeEntry.Value.IsWithinRange(totalChoiceValue))
                {
                    _definition.Psychotype = _psychotypeEntry.Key;
                    break;
                }
            }

            if (_definition.Psychotype != null && _descriptions.TryGetValue(_definition.Psychotype, out var description))
            {
                _definition.PsychotypeDescription = description;
            }

            if (!string.IsNullOrEmpty(_definition.PsychotypeDescription))
            {
                var _splitIndex = _definition.PsychotypeDescription.IndexOf("Recommendations:");
                if (_splitIndex != -1)
                {
                    _definition.Info = _definition.PsychotypeDescription.Substring(0, _splitIndex).Trim();
                    _definition.Recommendations = _definition.PsychotypeDescription.Substring(_splitIndex + "Recommendations:".Length).Trim();
                }
                else
                {
                    _definition.Info = _definition.PsychotypeDescription;
                }
            }

            return _definition;
        }
    }
}
