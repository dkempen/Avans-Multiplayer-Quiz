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

                Question question;
                //Tuple<Question, Scores> tuple;

                
                if (command == "questionScores")
                {
                     question = ReadQuestionAndScore().Item1;

                    Console.WriteLine("Question: " + question);
                    
                }
            }
        }

        public static IPAddress GetLocalIPAddress()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip;
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private Scores ReadEndScore()
        {
            JObject recieved = TcpReadWrite.Read(client);
            Scores score = TcpProtocol.EndScoresParse(recieved);
            return score;
        }

        private Tuple<Question, Scores> ReadQuestionAndScore()
        {
            JObject received = TcpReadWrite.Read(client);
            Tuple<Question, Scores> tuple;
            tuple = TcpProtocol.QuestionScoresParse(received);
            return tuple;
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
