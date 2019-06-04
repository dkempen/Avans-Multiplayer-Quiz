using System;
using Multiplayer_Quiz.Presentation.WPF;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using QuizShared.Game;
using Multiplayer_Quiz.Networking;

namespace Multiplayer_Quiz
{
   
    public partial class Form : System.Windows.Forms.Form
    {
        
        WPF wpf;
        Server server;
        private List<Question> questions = new List<Question>();
        public bool gameStarted = false;

        public Form()
        {
            server = new Server(this);
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            questions = ReadQuestionsFromDatabase();
            wpf = new WPF(server, questions);
            wpf.IPadressText.Text = "IPadress: " + LocalIPAddress();
            wpf.inGameLabel.Visibility = Visibility.Hidden;
            SetQuestionListData();

            new Thread(() => server.RunServer(questions)).Start();
            elementHost1.Child = wpf;
        }

        public static string LocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public void SetNumberOfPlayerText(int amount)
        {
            Invoke(new Action(() => wpf.totalClientsText.Text = "Total Clients: " + amount.ToString()));
        }

        public void setGameStarted()
        {
            if (gameStarted)
            {
                Invoke(new Action(() => wpf.startBtn.Visibility = Visibility.Hidden));
                Invoke(new Action(() => wpf.inGameLabel.Visibility = Visibility.Visible));
            }
            else
            {
                Invoke(new Action(() => wpf.startBtn.Visibility = Visibility.Visible));
                Invoke(new Action(() => wpf.inGameLabel.Visibility = Visibility.Hidden));
            }
        }

        public void SetQuestionListData()
        {
            List<Question> Questions = new List<Question>();
            foreach (Question Question in questions)
            {
                Questions.Add(new Question(Question.GetQuestion(),Question.GetAnswers()) {question = Question.GetQuestion()});
            }

            Invoke(new Action(() => wpf.QuestionListView.ItemsSource = Questions));
        }
 

        public List<Question> ReadQuestionsFromDatabase()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"questions.txt", FileMode.OpenOrCreate, FileAccess.Read);
            if (stream.Length == 0)
                return new List<Question>();
            var questions = (List<Question>) formatter.Deserialize(stream);
            return questions;
        }
    }
}
