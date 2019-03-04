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
        private int[] scores;
        private int playerCount;
        private int index;

        public GameLogic(List<Question> questions, int playerCount)
        {
            this.questions = questions;
            scores = new int[playerCount];
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

        public void AddScore(int playerIndex, int time)
        {
            scores[playerIndex] += 1 / time; // TODO: Change score formula
        }

        public int[] GetScores()
        {
            return scores;
        }
    }
}
