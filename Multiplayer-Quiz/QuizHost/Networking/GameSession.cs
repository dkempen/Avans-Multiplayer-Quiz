using Multiplayer_Quiz.Game;
using Newtonsoft.Json.Linq;
using QuizShared.Game;
using QuizShared.Networking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multiplayer_Quiz.Networking
{
    class GameSession
    {
        private GameLogic gameLogic;
        private List<ClientHandler> clientHandlers = new List<ClientHandler>();
        private List<Question> questions;
        private Scores scores;
        List<int> ids = new List<int>();

        public GameSession(List<TcpClient> clients, List<Question> questions)
        {
            int id = 0;
            foreach (TcpClient client in clients)
                clientHandlers.Add(new ClientHandler(client, id++));
            ids.Add(id);
            this.questions = questions;

            StartGame();
        }

        public void StartGame()
        {
            // Intis
            int players = clientHandlers.Count();
            
            gameLogic = new GameLogic(questions, players);
            Question currentQuestion;

            // Start the game loop
            while (true)
            {
                currentQuestion = gameLogic.NextQuestion();
                if (currentQuestion == null)
                {
                    EndGame();
                    return;
                }
                // Send out the question + scores to the clients
                // TODO: loop through all clients and send them stuff
                foreach(ClientHandler client in clientHandlers)
                {
                    client.Write(TcpProtocol.QuestionScoresSend1(currentQuestion));   
                }

                // Wait for all clients to be finished (in threads)
                while (true) // TODO: replace with check if clients are finished
                {
                    Thread.Sleep(1);
                }

                //gameLogic.AddScore(); // TODO: do this in callback thread
            }
        }

        public void EndGame()
        {
            //Update de highscores en send de highscores
            foreach (ClientHandler client in clientHandlers)
            {
                scores.GetScore(client.id);
                client.Write(TcpProtocol.EndScoresSend(scores));
            }

            // Kick all
            foreach(ClientHandler client in clientHandlers)
            {
                clientHandlers.Remove(client);
            }
        }

        private void Broadcast(JObject message)
        {
            foreach (ClientHandler client in clientHandlers) {
                client.Write(message);
            }
        }



        private void ShowQuestion(Question question, int[] scores)
        {

        }

        private int ReadPlayerTime(ClientHandler client)
        {
            JObject jObject = client.Read();
            int playertime = TcpProtocol.TimeParse(jObject);

            return playertime;
        }

       
    }
}
