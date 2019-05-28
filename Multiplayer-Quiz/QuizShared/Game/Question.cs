using Newtonsoft.Json;

namespace QuizShared.Game
{
    [JsonObject(MemberSerialization.Fields)]
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
    }
}
