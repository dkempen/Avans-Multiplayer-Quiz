using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuizShared.Game;
using System;

namespace QuizShared.Networking
{
    static class TcpProtocol
    {
        public static string command = "command";
        public static string data = "data";

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

        public static JObject SendId(int id)
        {
            return new JObject
            {
                {"command","id"},
                {"id",id }
            };
        }

        public static int ReadId(JObject json)
        {
            return JsonConvert.DeserializeObject<int>((string)json["id"]);
        }

        public static Tuple<Question, Scores> QuestionScoresParse(JObject json)
        {
            return new Tuple<Question, Scores>(
                JsonConvert.DeserializeObject<Question>((string)json[data]["question"]),
                JsonConvert.DeserializeObject<Scores>((string)json[data]["scores"]));
        }

        public static JObject EndScoresSend(Scores scores)
        {
            return new JObject
            {
                {command, "endScores"},
                {data, JsonConvert.SerializeObject(scores)}
            };
        }

        public static Scores EndScoresParse(JObject json)
        {
            return JsonConvert.DeserializeObject<Scores>((string)json[data]);
        }
        #endregion Send by Host

        #region Send by Client
        public static JObject TimeSend(int time)
        {
            return new JObject
            {
                {command, "time"},
                {data, time}
            };
        }

        public static Tuple<Question, Scores> QuestionAndScoreParse(JObject message)
        {
            var tuple = QuestionScoresParse(message);
            return tuple;
        }

        public static int TimeParse(JObject json)
        {
            return (int)json[data];
        }
        #endregion Send by Client
    }
}
