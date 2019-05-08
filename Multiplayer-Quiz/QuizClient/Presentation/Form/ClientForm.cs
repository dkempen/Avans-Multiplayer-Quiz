using QuizClient.Networking;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;

namespace QuizClient
{
    public partial class ClientForm : System.Windows.Forms.Form
    {
        private List<Panel> panels = new List<Panel>();
        private Panel currentPanel;
        private GamePanel currentGamePanel;

        public ClientForm()
        {
            InitializeComponent();

            AddPanels();
            SetPanel(GamePanel.Ip);

            ClientForm_Resize(null, null);
        }

        #region Form stuff

        private void Form_Load(object sender, EventArgs e)
        {
        }

        // Listener for the ip textbox
        private void IPTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;

            e.Handled = true;
            e.SuppressKeyPress = true;

            string ipAddress = IPTextBox.Text;
            if (!ValidateIPv4(ipAddress))
            {
                IPTextBox.Text = @"Invalid IP";
            }
            else
            {
                // TODO: Try to connect with the server and handle succes and failure
                // NetworkHandler networkHandler = new NetworkHandler();
                // new Thread(networkHandler.RunClient).Start();
                SetPanel(GamePanel.Lobby);
            }
        }

        // Checks whether or not the user input qualifies as an ip address
        public bool ValidateIPv4(string ipString)
        {
            if (string.IsNullOrWhiteSpace(ipString))
                return false;
            string[] splitValues = ipString.Split('.');
            return splitValues.Length == 4 && splitValues.All(r => byte.TryParse(r, out byte result));
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

        #endregion Form stuff

        // Adds all the panels to a list so that it can be iterated upon
        private void AddPanels()
        {
            panels.Add(IPPanel);
            panels.Add(LobbyPanel);
            panels.Add(QuestionPanel);
            panels.Add(WaitPanel);

            foreach (Panel panel in panels)
                panel.Visible = false;
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
                    return;
                }
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
                case GamePanel.Wait: SetPanel(GamePanel.Ip); break;
                default: SetPanel(GamePanel.Ip); break;
            }
        }

        // Abstraction for selecting panels
        public enum GamePanel
        {
            Ip, Lobby, Question, Wait
        }
    }
}
