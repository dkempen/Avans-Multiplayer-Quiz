using Newtonsoft.Json.Linq;
using QuizShared.Networking;
using System;
using System.Net.Sockets;

namespace Multiplayer_Quiz.Networking
{
    internal class ClientHandler
    {
        private TcpClient client;
        public int id;

        public ClientHandler(TcpClient client, int id)
        {
            this.client = client;
            this.id = id;
        }

        public void Write(JObject message)
        {
            TcpReadWrite.Write(client, message);
        }

        public JObject Read()
        {
            try
            {
                return TcpReadWrite.Read(client);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception");
                return null;
            }
        }

        public int getId()
        {
            return this.id;
        }

        public void Close()
        {
            client.Close();
        }
    }
}
