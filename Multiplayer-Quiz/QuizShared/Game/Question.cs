using System;
using System.Collections.Generic;
using System.Text;

namespace QuizShared.Game
{
    public class Question
    {
        private string question;
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
    }
}
