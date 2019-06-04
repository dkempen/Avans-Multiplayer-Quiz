using Newtonsoft.Json.Linq;
using QuizShared.Networking;
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace QuizClient.Networking
{
    internal class NetworkHandler
    {
        private TcpClient client;
        private readonly ClientForm form;

        public NetworkHandler(ClientForm clientForm)
        {
            form = clientForm;
        }

        public void RunClient(object ipAddress)
        {
            client = new TcpClient(ipAddress.ToString(), 6969);

            while (true)
            {
                JObject received = TcpReadWrite.Read(client);
                string command = (string)received["command"];

                switch (command)
                {
                    case "id":
                        form.Invoke(new Action(() => form.GetId(TcpProtocol.ReadId(received))));
                        break;
                    case "questionScores":
                        form.Invoke(new Action(() => form.HandleQuestionsScores(TcpProtocol.QuestionAndScoreParse(received))));
                        break;
                    case "endScores":
                        form.Invoke(new Action(() => form.HandleEndGame(TcpProtocol.EndScoresParse(received))));
                        client.GetStream().Close();
                        client.Close();
                        return;
                }
            }
        }

        public void SendTime(int time)
        {
            TcpReadWrite.Write(client, TcpProtocol.TimeSend(time));
        }

        public static IPAddress GetLocalIpAddress()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip;
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        
        // Checks whether or not the user input qualifies as an ip address
        public static bool ValidateIPv4(string ipString)
        {
            if (string.IsNullOrWhiteSpace(ipString))
                return false;
            string[] splitValues = ipString.Split('.');
            return splitValues.Length == 4 && splitValues.All(r => byte.TryParse(r, out byte result));
        }
    }
}
