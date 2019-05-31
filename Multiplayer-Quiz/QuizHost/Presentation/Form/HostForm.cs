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
        Server server = new Server();

        public Form()
        {
            InitializeComponent();
            wpf = new WPF(server);
            List<Question> questions = new List<Question>();
            //placeholder question
            string[] items1 = { "item1", "item1", "item1", "item1" };
            questions.Add(new Question("Welke kleur is een banaan",items1) { question = "Welke kleur is een banaan?"});
            wpf.QuestionListView.ItemsSource = questions;

            wpf.IPadressText.Text = "IPadress: " + LocalIPAddress();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            new Thread(server.RunServer).Start();
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
       }
}
