using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using QuizShared.Game;
using QuizShared.Networking;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace QuizClient.Networking
{
    class NetworkHandler
    {
        private TcpClient client;

        public void RunClient()
        {
            client = new TcpClient(GetLocalIPAddress().ToString(), 6969);

            while (true)
            {
                JObject received = TcpReadWrite.Read(client);
                string command = (string)received["command"];

                if (command == "questionScores")
                {
                    HandleQuestions(received);
                    HandleScores(received);
                    HandleAwnsers(received);

                    //placeholder for score
                    int time = 500;
                    SendTime(500);
                }

                
            }
        }

        private string HandleQuestions(JObject data)
        {
            Question question;
            question = TcpProtocol.ReadQuestionAndScore(data).Item1;

            //For debugging
            string Question = question.GetQuestion();
            Console.WriteLine("Question: " + Question);

            return Question;
        }

        private Scores HandleScores(JObject data)
        {
            Scores score = TcpProtocol.ReadQuestionAndScore(data).Item2;
            //for debugging
            score.ToString();

            return score;
        }

        private List<string> HandleAwnsers(JObject data)
        {
            Question question;
            question = TcpProtocol.ReadQuestionAndScore(data).Item1;

            string[] awnser = question.GetAnswers();
            List<string> awnsers = new List<string>();

            for (int i = 0; i < 4; i++)
            {
                awnsers.Add(awnser[i]);
                //for debugging
                Console.WriteLine("Awnser: " + awnser[i]);
            }
                
            return awnsers;
        }
        public static IPAddress GetLocalIPAddress()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip;
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void SendTime(int time)
        {
            TcpReadWrite.Write(client, TcpProtocol.TimeSend(time));
        }

        private Scores ReadEndScore()
        {
            JObject recieved = TcpReadWrite.Read(client);
            Scores score = TcpProtocol.EndScoresParse(recieved);
            return score;
        }

        private bool ReadEndGame()
        {
            JObject received = TcpReadWrite.Read(client);
            string command = (string)received["command"];

            if (command == "endScores")
                return true;
            return false;
        }
    }
}
