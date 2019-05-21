using System;
using Multiplayer_Quiz.Presentation.WPF;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizShared.Game;

namespace Multiplayer_Quiz
{
   
    public partial class Form : System.Windows.Forms.Form
    {
        List<Question> questions = new List<Question>();
        WPF wpf = new WPF();

        public Form()
        {
            InitializeComponent();
           
        
        }

        private void Form_Load(object sender, EventArgs e)
        {
            elementHost1.Child = wpf;
            string[] items1 = { "item1", "item1", "item1", "item1" };
            wpf.QuestionListView.Items.Add(new Question("Welke kleur is een banaan?", items1));
        }

       
    }
}
