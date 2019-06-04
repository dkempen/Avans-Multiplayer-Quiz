using MaterialSkin.Controls;
using QuizClient.Networking;
using QuizShared.Game;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;
using Timer = System.Timers.Timer;

namespace QuizClient
{
    public partial class ClientForm : Form
    {
        private List<Panel> panels = new List<Panel>();
        private Panel currentPanel;
        private GamePanel currentGamePanel;

        private NetworkHandler networkHandler;

        private const int AMOUNT_OF_ANSWERS = 4;
        private MaterialRaisedButton[] answersButtons = new MaterialRaisedButton[AMOUNT_OF_ANSWERS];
        private int correctButton;

        private Stopwatch stopwatch = new Stopwatch();
        private Timer timer = new Timer();
        private int seconds;
        private int id;

        public ClientForm()
        {
            InitializeComponent();

            AddPanelsAndButtons();
            SetPanel(GamePanel.Ip);
            ClientForm_Resize(null, null);

            timer.Elapsed += OnTimedEvent;
            timer.Interval = 1000;

            networkHandler = new NetworkHandler(this);
        }

        private void Form_Load(object sender, EventArgs e)
        {
        }
        
        #region Form Callbacks

        // Listener for the ip textbox
        private void IPTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;

            e.Handled = true;
            e.SuppressKeyPress = true;

            string ipAddress = IPTextBox.Text;
            if (!NetworkHandler.ValidateIPv4(ipAddress))
            {
                IPTextBox.Text = @"Invalid IP";
            }
            else
            {
                new Thread(networkHandler.RunClient).Start(IPTextBox.Text);
                SetPanel(GamePanel.Lobby);
            }
        }

        // Centering the panels when the window gets resized
        private void ClientForm_Resize(object sender, EventArgs e)
        {
            foreach (Panel panel in panels)
            {
                panel.Location = new Point(ClientSize.Width / 2 - panel.Size.Width / 2,
                    ClientSize.Height / 2 - panel.Size.Height / 2);
                panel.Anchor = AnchorStyles.None;
            }

            QuestionPanel.Dock = DockStyle.Fill;
        }

        // Shortcut to reliably close the form with the escape key
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Temporary N keypress to go to the next panel
        private void ClientForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.N)
                return;
            switch (currentGamePanel)
            {
                case GamePanel.Ip: SetPanel(GamePanel.Lobby); break;
                case GamePanel.Lobby: SetPanel(GamePanel.Question); break;
                case GamePanel.Question: SetPanel(GamePanel.Wait); break;
                case GamePanel.Wait: SetPanel(GamePanel.Scores); break;
                case GamePanel.Scores: SetPanel(GamePanel.Ip); break;
                default: SetPanel(GamePanel.Ip); break;
            }
        }

        private void AnswerButtonA_Click(object sender, EventArgs e)
        {
            OnQuestionAnswered(sender);
        }

        private void AnswerButtonB_Click(object sender, EventArgs e)
        {
            OnQuestionAnswered(sender);
        }

        private void AnswerButtonC_Click(object sender, EventArgs e)
        {
            OnQuestionAnswered(sender);
        }

        private void AnswerButtonD_Click(object sender, EventArgs e)
        {
            OnQuestionAnswered(sender);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            SetPanel(GamePanel.Ip);
        }

        #endregion Form Callbacks

        #region Panel Logic

        // Adds all the panels to a list so that it can be iterated upon
        private void AddPanelsAndButtons()
        {
            panels.Add(IPPanel);
            panels.Add(LobbyPanel);
            panels.Add(QuestionPanel);
            panels.Add(WaitPanel);
            panels.Add(ScoresPanel);

            foreach (Panel panel in panels)
                panel.Visible = false;

            int i = 0;
            answersButtons[i++] = AnswerButtonA;
            answersButtons[i++] = AnswerButtonB;
            answersButtons[i++] = AnswerButtonC;
            answersButtons[i] = AnswerButtonD;
        }

        // Switches from one panel to another by making it visible and hiding the others
        private void SetPanel(GamePanel panel)
        {
            foreach (Panel p in panels)
                if (p.Name.ToLower().Contains(panel.ToString().ToLower()))
                {
                    if (currentPanel != null)
                        currentPanel.Visible = false;
                    currentPanel = p;
                    currentPanel.Visible = true;
                    currentGamePanel = panel;

                    BackColor = currentPanel.BackColor;
                    break;
                }

            // Load events for specific panels
            switch (currentGamePanel)
            {
                case GamePanel.Ip:
                    IPTextBox.Text = NetworkHandler.GetLocalIPAddress().ToString();
                    break;

                case GamePanel.Lobby:
                    break;

                case GamePanel.Question:
                    break;

                case GamePanel.Wait:
                    break;

                case GamePanel.Scores:
                    break;

                default:
                    break;
            }
        }

        // Abstraction for selecting panels
        public enum GamePanel
        {
            Ip, Lobby, Question, Wait, Scores
        }

        #endregion Panel Logic

        #region Question Logic

        public void HandleQuestionsScores(Tuple<Question, Scores> received)
        {
            // Go to question panel
            SetPanel(GamePanel.Question);
            Question question = received.Item1;
            QuestionLabel.Text = question.GetQuestion();

            // Generate random sequence
            int[] sequence = new int[AMOUNT_OF_ANSWERS];
            for (int i = 0; i < sequence.Length; i++)
                sequence[i] = i;
            Randomize(sequence);

            // Place questions according to the random sequence
            for (int i = 0; i < sequence.Length; i++)
            {
                if (i == 0)
                    correctButton = sequence[i];
                answersButtons[sequence[i]].Text = question.GetAnswers()[i];
            }

            // Display score
            ScoreLabel.Text = received.Item2.GetScore(getID(id)).ToString();

            // Set 10 second timer
            seconds = 10;
            CounterLabel.Text = seconds.ToString();
            timer.Enabled = true;
            stopwatch.Restart();

            // Enable all buttons
            enableButtons(true);
        }

        public int getID(int id)
        {
            this.id = id;
            return this.id;
        }

        private void Randomize(int[] array)
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < array.Length - 1; i++)
            {
                int j = rand.Next(i, array.Length);
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            seconds--;
            Invoke(new Action(() => CounterLabel.Text = seconds.ToString()));

            // If the timer is zero, continue to the next question
            if (seconds > 0)
                return;

            timer.Enabled = false;
            Invoke(new Action(() => OnQuestionAnswered(null)));
        }

        private void OnQuestionAnswered(object sender)
        {
            // Disable all buttons
            enableButtons(false);

            // Stop the stopwatch and timer
            stopwatch.Stop();
            timer.Enabled = false;

            // Check which button was pressed
            int answeredIndex = -1;
            for (int i = 0; i < answersButtons.Length; i++)
                if ((MaterialRaisedButton)sender == answersButtons[i])
                    answeredIndex = i;

            // Check if the answer is correct and send the time
            if (answeredIndex == correctButton)
                networkHandler.SendTime((int)stopwatch.ElapsedMilliseconds);
            else
                networkHandler.SendTime(-1);
        }

        private void enableButtons(bool enable)
        {
            foreach (var button in answersButtons)
                button.Enabled = enable;
        }
        #endregion Question Logic

        #region Endgame Logic

        public void HandleEndGame(Scores scores)
        {
            SetPanel(GamePanel.Scores);
            ScoresFlowPanel.Controls.Clear();

            var sorted = new Dictionary<int, int>();
            for (var i = 0; i < scores.Size(); i++)
                sorted.Add(i, scores.GetScore(i));

            foreach (var score in sorted.OrderByDescending(key => key.Value))
            {
                var scoreLabel = new MaterialLabel {Text = score.Key + @": " + score.Value};
                ScoresFlowPanel.Controls.Add(scoreLabel);
                if (score.Key == id)
                    scoreLabel.Font = new Font(scoreLabel.Font, FontStyle.Bold);
            }
        }

        #endregion Endgame Logic
    }
}
