using PsychologicalTestWithBlazor.Components.Models;

namespace PsychologicalTestWithBlazor.Components.Services.Abstractions
{
    public interface ILoadQuestionsFromFileService
    {
        Task<List<Question>> LoadQuestions(string filePath);
    }
}
