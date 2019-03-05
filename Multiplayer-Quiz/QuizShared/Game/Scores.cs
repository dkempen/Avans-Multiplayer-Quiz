using System.Collections.Generic;

namespace QuizShared.Game
{
    class Scores
    {
        // Scores saved in a list with an int array: 0 is the id, 1 is the score
        private readonly List<int[]> _scores = new List<int[]>();

        public Scores(List<int> ids)
        {
            foreach (int id in ids)
                _scores.Add(new[] { id, 0 });
        }

        public void AddToScore(int id, int scoreToAdd)
        {
            foreach (int[] score in _scores)
                if (score[0] == id)
                {
                    score[1] += scoreToAdd;
                    return;
                }
        }

        public int GetScore(int id)
        {
            foreach (int[] score in _scores)
                if (score[0] == id)
                    return score[1];
            return -1;
        }
    }
}
