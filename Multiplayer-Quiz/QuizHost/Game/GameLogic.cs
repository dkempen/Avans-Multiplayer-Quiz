using QuizShared.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Multiplayer_Quiz.Game
{
    class GameLogic
    {
        private List<Question> questions;
        private Scores scores;
        private int playerCount;
        private int index;

        public GameLogic(List<Question> questions, int playerCount, List<int> ids)
        {
            this.questions = questions;
            scores = new Scores(ids);
            this.playerCount = playerCount;
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
