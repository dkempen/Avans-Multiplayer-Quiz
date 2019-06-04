using Multiplayer_Quiz.Networking;
using Multiplayer_Quiz.Presentation.WPF;
using QuizShared.Game;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

namespace Multiplayer_Quiz
{
    public partial class Form : System.Windows.Forms.Form
    {
        private WPF wpf;
        private readonly Server server;
        private List<Question> questions = new List<Question>();
        public bool gameStarted = false;

        public Form()
        {
            server = new Server(this);
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            questions = ReadQuestionsFromDatabase();
            wpf = new WPF(server, questions);
            wpf.IPadressText.Text = "Ip-Address: " + LocalIpAddress();
            wpf.inGameLabel.Visibility = Visibility.Hidden;
            SetQuestionListData();

            new Thread(() => server.RunServer(questions)).Start();
            elementHost1.Child = wpf;
        }

        public static string LocalIpAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public void SetNumberOfPlayerText(int amount)
        {
            Invoke(new Action(() => wpf.totalClientsText.Text = "Total Clients: " + amount.ToString()));
        }

        public void SetGameStarted()
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
            List<Question> questions = new List<Question>();
            foreach (Question question in questions)
                questions.Add(new Question(question.GetQuestion(), question.GetAnswers()) { question = question.GetQuestion() });

            Invoke(new Action(() => wpf.QuestionListView.ItemsSource = questions));
        }

        public List<Question> ReadQuestionsFromDatabase()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"questions.txt", FileMode.OpenOrCreate, FileAccess.Read);
            if (stream.Length == 0)
                return new List<Question>();
            var questions = (List<Question>)formatter.Deserialize(stream);
            return questions;
        }
    }
}
