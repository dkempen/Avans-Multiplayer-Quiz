using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizClient.Networking;

namespace QuizClient
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            NetworkHandler networkHandler = new NetworkHandler();
            new Thread(networkHandler.RunClient).Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
