using PsychologicalTestWithBlazor.Models;

namespace PsychologicalTestWithBlazor.Services.Abstractions
{
    public interface ILoadQuestionsFromFileService
    {
        Task<List<Question>> LoadQuestions(string FilePath);
    }
}
