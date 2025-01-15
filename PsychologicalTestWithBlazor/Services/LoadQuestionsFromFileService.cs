using PsychologicalTestWithBlazor.Models;
using PsychologicalTestWithBlazor.Services.Abstractions;

namespace PsychologicalTestWithBlazor.Services
{
    public class LoadQuestionsFromFileService : ILoadQuestionsFromFileService
    {
        private readonly IWebHostEnvironment _environment;

        public LoadQuestionsFromFileService(IWebHostEnvironment Environment)
        {
            _environment = Environment;
        }

        public async Task<List<Question>> LoadQuestions(string FilePath)
        {
            var _questions = new List<Question>();
            var _answerOptions = AnswerOptions.Get();

            var _answers = new List<Answer>();
            int index = 1;
            foreach (var aop in _answerOptions)
            {
                _answers.Add(new Answer { Id = index, Text = aop.Key, ChoiceValue = aop.Value });
                index++;
            }

            var _path = Path.Combine(_environment.ContentRootPath, FilePath);
            var _fileContent = await File.ReadAllTextAsync(_path);
            var _lines = _fileContent.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < _lines.Length; i++)
            {
                var _text = _lines[i].Trim();
                if (!string.IsNullOrEmpty(_text))
                {
                    _questions.Add(new Question
                    {
                        Id = i + 1,
                        Text = _text,
                        Answers = _answers
                    });
                }
            }

            return _questions;
        }

    }
}
