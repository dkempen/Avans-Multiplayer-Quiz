using Multiplayer_Quiz.Game;
using Newtonsoft.Json.Linq;
using QuizShared.Game;
using QuizShared.Networking;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;

namespace Multiplayer_Quiz.Networking
{
    internal class GameSession
    {
        private GameLogic gameLogic;
        private readonly List<ClientHandler> clientHandlers = new List<ClientHandler>();
        private readonly List<Question> questions;
        private readonly List<int> ids = new List<int>();
        private readonly Form form;

        public GameSession(List<TcpClient> clients, List<Question> questions, Form form)
        {
            int id = 0;
            foreach (TcpClient client in clients)
            {
                clientHandlers.Add(new ClientHandler(client, id));
                ids.Add(id++);
            }
            this.questions = questions;
            this.form = form;

            StartGame();
        }

        public void StartGame()
        {
            // Intis
            int players = clientHandlers.Count;
            form.gameStarted = true;
            form.SetGameStarted();
            gameLogic = new GameLogic(questions, ids);

            foreach (ClientHandler client in clientHandlers)
            {
                client.Write(TcpProtocol.SendId(client.id));
            }

            // Start the game loop
            while (true)
            {
                var currentQuestion = gameLogic.NextQuestion();
                if (currentQuestion == null)
                {
                    EndGame();
                    form.gameStarted = false;
                    form.SetGameStarted();
                    return;
                }

                // Send out the question + scores to the clients
                Broadcast(TcpProtocol.QuestionScoresSend(currentQuestion, gameLogic.GetScores()));

                // Wait for all clients to be finished (in threads)
                int finishedClients = 0;
                while (finishedClients != players)
                {
                    foreach (ClientHandler client in clientHandlers)
                    {
                        int playerTime = TcpProtocol.TimeParse(client.Read());
                        gameLogic.AddToScore(client.id, playerTime);
                        finishedClients++;

                        //for debugging
                        Console.WriteLine(@"Playertime: " + playerTime);
                        Console.WriteLine(@"PlayerID: " + client.id + @"Score: " + gameLogic.GetScore(client.id));
                    }
                    Thread.Sleep(1);
                }
            }
        }

        public void EndGame()
        {
            //Update de highscores en send de highscores
            foreach (ClientHandler client in clientHandlers)
            {
                gameLogic.GetScore(client.id);
                client.Write(TcpProtocol.EndScoresSend(gameLogic.GetScores()));
            }
        }

        private void Broadcast(JObject message)
        {
            foreach (ClientHandler client in clientHandlers)
                client.Write(message);
        }
    }
}
