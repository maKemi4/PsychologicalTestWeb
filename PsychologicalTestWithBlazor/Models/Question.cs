﻿namespace PsychologicalTestWithBlazor.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }
        public int? SelectedAnswerId { get; set; }
    }
}