using Newtonsoft.Json;
using System.Collections.Generic;

namespace QuizShared.Game
{
    [JsonObject(MemberSerialization.Fields)]
    public class Scores
    {
        // Scores saved in a list with an int array: 0 is the id, 1 is the score
        private List<int[]> scores = new List<int[]>();

        public Scores(List<int> ids)
        {
            foreach (int id in ids)
                scores.Add(new[] { id, 0 });
        }

        public void AddToScore(int id, int time)
        {
            // If the question was answered incorrectly (-1), don't add a score
            if (time == -1)
                return;

            // TODO: Change calculation of the score
            int scoreToAdd = 10000 - time;

            // If points are to be awarded, add them to the total
            foreach (int[] score in scores)
                if (score[0] == id)
                {
                    score[1] += scoreToAdd;
                    return;
                }
        }

        public int GetScore(int id)
        {
            foreach (int[] score in scores)
                if (score[0] == id)
                    return score[1];
            return -1;
        }

        public int Size()
        {
            return scores.Count;
        }
    }
}
