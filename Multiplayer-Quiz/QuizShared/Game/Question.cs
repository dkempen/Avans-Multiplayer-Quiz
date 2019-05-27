﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuizShared.Game
{
    public class Question
    {
        public string question { get; set; }
        private string[] answers; // First is always the correct answer

        public Question(string question, string[] answers)
        {
            this.question = question;
            this.answers = answers;
        }

        public string[] GetAnswers()
        {
            return answers;
        }

        public string GetQuestion()
        {
            return question;
        }

        public override string ToString()
        {
            return this.question;
        }
    }
}
