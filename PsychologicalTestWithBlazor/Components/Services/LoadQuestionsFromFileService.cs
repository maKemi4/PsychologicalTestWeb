using PsychologicalTestWithBlazor.Components.Models;
using PsychologicalTestWithBlazor.Components.Services.Abstractions;

namespace PsychologicalTestWithBlazor.Components.Services
{
    public class LoadQuestionsFromFileService : ILoadQuestionsFromFileService
    {
        private readonly IWebHostEnvironment _environment;

        public LoadQuestionsFromFileService (IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public async Task<List<Question>> LoadQuestions (string filePath)
        {
            var questions = new List<Question>();
            var answerOptions = AnswerOptions.Get();

            var answers = new List<Answer>();
            int index = 1;
            foreach (var aop in answerOptions)
            {
                answers.Add(new Answer { Id = index, Text = aop.Key, ChoiceValue = aop.Value });
                index++;
            }

            var path = Path.Combine(_environment.ContentRootPath, filePath);
            var fileContent = await File.ReadAllTextAsync(path);
            var lines = fileContent.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < lines.Length; i++)
            {
                var text = lines[i].Trim();
                if (!string.IsNullOrEmpty(text))
                {
                    questions.Add(new Question
                    {
                        Id = i + 1,
                        Text = text,
                        Answers = answers
                    });
                }
            }

            return questions;
        }

    }
}
