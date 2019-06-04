using QuizShared.Game;
using System.Collections.Generic;

namespace Multiplayer_Quiz.Game
{
    internal class GameLogic
    {
        private List<Question> questions;
        private Scores scores;
        private int index;

        public GameLogic(List<Question> questions, List<int> ids)
        {
            this.questions = questions;
            scores = new Scores(ids);
            index = -1;
        }

        public Question NextQuestion()
        {
            index++;
            if (index >= questions.Count)
                return null;
            return questions[index];
        }

        public void AddToScore(int playerId, int time)
        {
            scores.AddToScore(playerId, time);
        }

        public Scores GetScores()
        {
            return scores;
        }

        public int GetScore(int playerId)
        {
            return scores.GetScore(playerId);
        }
    }
}
