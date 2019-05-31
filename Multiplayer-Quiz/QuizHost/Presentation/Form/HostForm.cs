using System;
using Multiplayer_Quiz.Presentation.WPF;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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

        public Form()
        {
            server = new Server(this);
            InitializeComponent();
            wpf = new WPF(server, questions);
            
            wpf.IPadressText.Text = "IPadress: " + LocalIPAddress();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            questions.Add(new Question("What is the first positive natural number?", new[] { "1", "2", "3", "4" }));
            questions.Add(new Question("What color is a banana?", new[] { "Yellow", "Red", "Purple", "Pink" }));
            questions.Add(new Question("What color is an orange?", new[] { "Orange", "Red", "Purple", "Pink" }));
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

        public void SetQuestionListData()
        {
            List<Question> Questions = new List<Question>();
            foreach (Question Question in questions)
            {
                Questions.Add(new Question(Question.GetQuestion(),Question.GetAnswers()) {question = Question.GetQuestion()});
            }

            Invoke(new Action(() => wpf.QuestionListView.ItemsSource = Questions));
        }
    }
}
