using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuizShared.Game;
using System;

namespace QuizShared.Networking
{
    static class TcpProtocol
    {
        public static string Command = "command";
        public static string Data = "data";

        #region Helper methods
        public static string GetCommand(JObject json)
        {
            return (string)json[Command];
        }

        public static string GetData(JObject json)
        {
            return (string)json[Data];
        }
        #endregion Helper methods

        #region Send by Host
        public static JObject QuestionScoresSend(Question question, Scores scores)
        {
            return new JObject
            {
                {"command", "questionScores"},
                {"data", new JObject
                {
                    {"question", JsonConvert.SerializeObject(question)},
                    {"scores", JsonConvert.SerializeObject(scores)}
                }}
            };
        }

        public static Tuple<Question, Scores> QuestionScoresParse(JObject json)
        {
            return new Tuple<Question, Scores>(
                JsonConvert.DeserializeObject<Question>((string)json[Data]["question"]),
                JsonConvert.DeserializeObject<Scores>((string)json[Data]["scores"]));
        }

        public static JObject EndScoresSend(Scores scores)
        {
            return new JObject
            {
                {Command, "endScores"},
                {Data, JsonConvert.SerializeObject(scores)}
            };
        }

        public static Scores EndScoresParse(JObject json)
        {
            return JsonConvert.DeserializeObject<Scores>((string)json[Data]);
        }
        #endregion Send by Host

        #region Send by Client
        public static JObject TimeSend(int time)
        {
            return new JObject
            {
                {Command, "time"},
                {Data, time}
            };
        }

        public static int TimeParse(JObject json)
        {
            return (int)json[Data];
        }
        #endregion Send by Client
    }
}
