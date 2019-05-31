using QuizShared.Game;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Multiplayer_Quiz.Networking
{
    public class Server
    {
        private const int NUMBER_OF_PLAYERS = 4;

        private TcpListener tcpListener;
        private List<TcpClient> clients = new List<TcpClient>();

        public List<Question> questions = new List<Question>();
        public bool startGameCommand = false;
        private Form form;

        public Server(Form form)
        {
            this.form = form;
        }

        public void RunServer(List<Question> questions)
        {
            tcpListener = new TcpListener(GetLocalIPAddress(), 6969);
            tcpListener.Start();
            form.SetNumberOfPlayerText(clients.Count);

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
                    // Console.WriteLine("Timed out...");
                    // Check for start command
                    if (startGameCommand)
                    {
                        StartGame(questions);
//                        return;
                    }

                    // Start listening again because of timeout
                    tcpListener.Start();
                    continue;
                }

                // Check if number of clients is max and if not timeout
                if (clients.Count < NUMBER_OF_PLAYERS)
                {
                    // Add to client list
                    clients.Add(client);
                    form.SetNumberOfPlayerText(clients.Count);
                }
                else
                {
                    continue;
                }

                // check for start command
                if (clients.Count == NUMBER_OF_PLAYERS)
                {
                    StartGame(questions);
//                    return;
                }
            }
        }

        public void StartGame(List<Question> questions)
        {
            // TODO: Ping pong
            // Start game
            Console.WriteLine("Start Game!");
            new GameSession(clients, questions);
            
            startGameCommand = false;

            // Game is done, close all connections
            foreach (TcpClient client in clients)
            {
                client.GetStream().Close();
                client.Close();
            }
            clients.Clear();
            form.SetNumberOfPlayerText(clients.Count);
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
