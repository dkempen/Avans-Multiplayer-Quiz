using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuizShared.Networking;

namespace Multiplayer_Quiz.Networking
{
    class ClientHandler
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
                return JsonConvert.DeserializeObject<dynamic>((string)TcpReadWrite.Read(client));
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception");
                return null;
            }
        }
    }
}
