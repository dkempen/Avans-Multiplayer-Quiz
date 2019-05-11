using QuizShared.Game;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Multiplayer_Quiz.Networking
{
    internal class Server
    {
        private const int NUMBER_OF_PLAYERS = 1;

        private TcpListener tcpListener;
        private List<TcpClient> clients = new List<TcpClient>();

        public void RunServer()
        {
            tcpListener = new TcpListener(GetLocalIPAddress(), 6969);
            tcpListener.Start();

            while (true)
            {
                Console.WriteLine("Waiting for client..");
                TcpClient client;
                try
                {
                    new Timer(state => { tcpListener.Stop(); },
                        null, 1000, Timeout.Infinite);
                    client = tcpListener.AcceptTcpClient();
                    Console.WriteLine("Got a client!!!");
                }
                catch (SocketException)
                {
//                    Console.WriteLine("Timed out...");
                    // Check for start command
                    if (1 != 1)
                    {
                        StartGame();
                        return;
                    }
                    tcpListener.Start();
                    continue;
                }

                // Check if number of clients is max and if not timeout
                if (clients.Count < NUMBER_OF_PLAYERS)
                {
                    // Add to client list
                    clients.Add(client);
                }
                else
                {
                    continue;
                }

                // check for start command
                if (clients.Count == NUMBER_OF_PLAYERS)
                {
                    StartGame();
                    return;
                }
            }
        }

        private void StartGame()
        {
            // TODO: Ping pong
            // Start game
            Console.WriteLine("Start Game!");
            List<Question> questions = new List<Question>();
            string[] items = { "Item1", "Item2", "Item3", "Item4" };
            string[] items2 = { "Item1", "Item2", "Item3", "Item4" };
            questions.Add(new Question("A question?", items));
            questions.Add(new Question("Is een banaan geel?", items2));
            new GameSession(clients, questions);
        }

        public static IPAddress GetLocalIPAddress()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip;
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}
