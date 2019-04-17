using Multiplayer_Quiz.Game;
using QuizShared.Game;
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

        public GameSession(List<TcpClient> clients, List<Question> questions)
        {
            int id = 0;
            foreach (TcpClient client in clients)
                clientHandlers.Add(new ClientHandler(client, id++));
            this.questions = questions;
            StartGame();
        }

        public void StartGame()
        {
            // Intis...
            int players = 2; // TODO: get player count from ClientHandler list
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
            // Send scores

            // Kick all
        }

        private void ShowQuestion(Question question, int[] scores)
        {

        }
    }
}
