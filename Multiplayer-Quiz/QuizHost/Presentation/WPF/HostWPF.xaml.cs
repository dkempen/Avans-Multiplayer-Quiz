using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.VisualStyles;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Multiplayer_Quiz.Networking;
using QuizShared.Game;

namespace Multiplayer_Quiz.Presentation.WPF
{
    /// <summary>
    /// Interaction logic for WPF.xaml
    /// </summary>
    public partial class WPF : UserControl
    {
        private Server server;
        private List<Question> questions;

        public WPF(Server server, List<Question> questions)
        {
            InitializeComponent();
            this.server = server;
            this.questions = questions;
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }


        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            server.startGameCommand = true;
        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            QuestionListView.SelectedItems.Clear();

            ListViewItem item = sender as ListViewItem;
            if (item != null)
            {
                item.IsSelected = true;
                QuestionListView.SelectedItem = item;
            }
        }

        private void ListViewItem_PreviewMouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ListViewItem item = sender as ListViewItem;
            if (item != null && item.IsSelected)
            {
                Question q = item.Content as Question;
                QuestionTextBox.Text = q.GetQuestion();
                AnswerTextBox.Text = q.GetAnswers()[0];
                AnswerTextBox1.Text = q.GetAnswers()[1];
                AnswerTextBox2.Text = q.GetAnswers()[2];
                AnswerTextBox3.Text = q.GetAnswers()[3];
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            questions.Add(new Question("", new[] { "", "", "", "" }));
            QuestionListView.ItemsSource = questions;
            RefreshListView();
        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (QuestionListView.SelectedItems.Count <= 0)
                return;
            var q = (Question) QuestionListView.SelectedItems[0];
            questions.Remove(q);
            RefreshListView();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (QuestionListView.SelectedItems.Count <= 0)
                return;
            var q = (Question) QuestionListView.SelectedItems[0];

            string[] answers = {AnswerTextBox.Text, AnswerTextBox1.Text, AnswerTextBox2.Text, AnswerTextBox3.Text};
            q.SetQuestion(QuestionTextBox.Text);
            q.SetAnswer(answers);
            RefreshListView();
        }

        private void RefreshListView()
        {
            var view = CollectionViewSource.GetDefaultView(QuestionListView.ItemsSource);
            view.Refresh();
        }
    }
}
