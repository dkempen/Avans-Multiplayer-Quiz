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
        private TcpListener tcpListener;
        private readonly List<TcpClient> clients = new List<TcpClient>();

        public bool startGameCommand;
        private readonly Form form;

        public Server(Form form)
        {
            this.form = form;
        }

        public void RunServer(List<Question> questions)
        {
            tcpListener = new TcpListener(GetLocalIpAddress(), 6969);
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
                    if (startGameCommand && clients.Count > 0)
                    {
                        StartGame(questions);
                    }

                    // Start listening again because of timeout
                    try
                    {
                        tcpListener.Start();
                    }
                    catch (Exception)
                    {
                        tcpListener.Stop();
                        tcpListener.Start();
                    }
                    continue;
                }
                
                // Add to client list
                clients.Add(client);
                form.SetNumberOfPlayerText(clients.Count);
            }
        }

        public void StartGame(List<Question> questions)
        {
            // Start game
            Console.WriteLine(@"Start Game!");
            new GameSession(clients, questions, form);

            startGameCommand = false;

            // Game is done, close all connections
            foreach (var client in clients)
            {
                client.GetStream().Close();
                client.Close();
            }
            clients.Clear();
            form.SetNumberOfPlayerText(clients.Count);
        }

        public static IPAddress GetLocalIpAddress()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip;
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}
