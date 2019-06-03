using System;
using Newtonsoft.Json;

namespace QuizShared.Game
{
    [JsonObject(MemberSerialization.Fields)]
    [Serializable]
    public class Question
    {
        public string question {get; set;}
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

        public void SetQuestion(string question)
        {
            this.question = question;
        }

        public void SetAnswer(string[] answers)
        {
            this.answers = answers;
        }
    }
}
