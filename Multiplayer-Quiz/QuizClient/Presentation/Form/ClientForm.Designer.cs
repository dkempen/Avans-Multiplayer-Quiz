namespace QuizClient
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LobbyPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LobbyLabel = new MaterialSkin.Controls.MaterialLabel();
            this.IPPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EnterIPLabel = new MaterialSkin.Controls.MaterialLabel();
            this.IPTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.QuestionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AnswersPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AnswerButtonD = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AnswerButtonB = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AnswerButtonA = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AnswerButtonC = new MaterialSkin.Controls.MaterialRaisedButton();
            this.InsideQuestionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CounterLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ScoreLabel = new MaterialSkin.Controls.MaterialLabel();
            this.QuestionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.WaitPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WaitLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ScoresPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HomeButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ScoresLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ScoresFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LobbyPanel.SuspendLayout();
            this.IPPanel.SuspendLayout();
            this.QuestionPanel.SuspendLayout();
            this.AnswersPanel.SuspendLayout();
            this.InsideQuestionPanel.SuspendLayout();
            this.WaitPanel.SuspendLayout();
            this.ScoresPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LobbyPanel
            // 
            this.LobbyPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LobbyPanel.AutoSize = true;
            this.LobbyPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LobbyPanel.BackColor = System.Drawing.Color.Orange;
            this.LobbyPanel.ColumnCount = 1;
            this.LobbyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LobbyPanel.Controls.Add(this.LobbyLabel, 0, 0);
            this.LobbyPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.LobbyPanel.Location = new System.Drawing.Point(411, 77);
            this.LobbyPanel.Name = "LobbyPanel";
            this.LobbyPanel.Padding = new System.Windows.Forms.Padding(20);
            this.LobbyPanel.RowCount = 1;
            this.LobbyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LobbyPanel.Size = new System.Drawing.Size(332, 79);
            this.LobbyPanel.TabIndex = 1;
            // 
            // LobbyLabel
            // 
            this.LobbyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LobbyLabel.AutoSize = true;
            this.LobbyLabel.Depth = 0;
            this.LobbyLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.LobbyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LobbyLabel.Location = new System.Drawing.Point(30, 30);
            this.LobbyLabel.Margin = new System.Windows.Forms.Padding(10);
            this.LobbyLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LobbyLabel.Name = "LobbyLabel";
            this.LobbyLabel.Size = new System.Drawing.Size(272, 19);
            this.LobbyLabel.TabIndex = 1;
            this.LobbyLabel.Text = "Waiting until the host starts the game...";
            this.LobbyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IPPanel
            // 
            this.IPPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IPPanel.AutoSize = true;
            this.IPPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IPPanel.BackColor = System.Drawing.Color.Tomato;
            this.IPPanel.ColumnCount = 1;
            this.IPPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.IPPanel.Controls.Add(this.EnterIPLabel, 0, 0);
            this.IPPanel.Controls.Add(this.IPTextBox, 0, 1);
            this.IPPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.IPPanel.Location = new System.Drawing.Point(12, 254);
            this.IPPanel.Name = "IPPanel";
            this.IPPanel.Padding = new System.Windows.Forms.Padding(20);
            this.IPPanel.RowCount = 2;
            this.IPPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.IPPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.IPPanel.Size = new System.Drawing.Size(178, 122);
            this.IPPanel.TabIndex = 2;
            // 
            // EnterIPLabel
            // 
            this.EnterIPLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EnterIPLabel.AutoSize = true;
            this.EnterIPLabel.Depth = 0;
            this.EnterIPLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.EnterIPLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EnterIPLabel.Location = new System.Drawing.Point(30, 30);
            this.EnterIPLabel.Margin = new System.Windows.Forms.Padding(10);
            this.EnterIPLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.EnterIPLabel.Name = "EnterIPLabel";
            this.EnterIPLabel.Size = new System.Drawing.Size(118, 19);
            this.EnterIPLabel.TabIndex = 5;
            this.EnterIPLabel.Text = "Enter IP address";
            this.EnterIPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IPTextBox
            // 
            this.IPTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IPTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IPTextBox.Depth = 0;
            this.IPTextBox.Hint = "123.123.123.12";
            this.IPTextBox.Location = new System.Drawing.Point(30, 69);
            this.IPTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.IPTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.PasswordChar = '\0';
            this.IPTextBox.SelectedText = "";
            this.IPTextBox.SelectionLength = 0;
            this.IPTextBox.SelectionStart = 0;
            this.IPTextBox.Size = new System.Drawing.Size(118, 23);
            this.IPTextBox.TabIndex = 5;
            this.IPTextBox.UseSystemPasswordChar = false;
            this.IPTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IPTextBox_KeyDown);
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.QuestionPanel.ColumnCount = 1;
            this.QuestionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.QuestionPanel.Controls.Add(this.AnswersPanel, 0, 1);
            this.QuestionPanel.Controls.Add(this.InsideQuestionPanel, 0, 0);
            this.QuestionPanel.Location = new System.Drawing.Point(267, 184);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Padding = new System.Windows.Forms.Padding(20);
            this.QuestionPanel.RowCount = 2;
            this.QuestionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.QuestionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.QuestionPanel.Size = new System.Drawing.Size(685, 471);
            this.QuestionPanel.TabIndex = 3;
            // 
            // AnswersPanel
            // 
            this.AnswersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswersPanel.ColumnCount = 2;
            this.AnswersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AnswersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AnswersPanel.Controls.Add(this.AnswerButtonD, 1, 1);
            this.AnswersPanel.Controls.Add(this.AnswerButtonB, 1, 0);
            this.AnswersPanel.Controls.Add(this.AnswerButtonA, 0, 0);
            this.AnswersPanel.Controls.Add(this.AnswerButtonC, 0, 1);
            this.AnswersPanel.Location = new System.Drawing.Point(23, 238);
            this.AnswersPanel.Name = "AnswersPanel";
            this.AnswersPanel.RowCount = 2;
            this.AnswersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AnswersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AnswersPanel.Size = new System.Drawing.Size(639, 210);
            this.AnswersPanel.TabIndex = 0;
            // 
            // AnswerButtonD
            // 
            this.AnswerButtonD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerButtonD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnswerButtonD.Depth = 0;
            this.AnswerButtonD.Location = new System.Drawing.Point(329, 115);
            this.AnswerButtonD.Margin = new System.Windows.Forms.Padding(10);
            this.AnswerButtonD.MouseState = MaterialSkin.MouseState.HOVER;
            this.AnswerButtonD.Name = "AnswerButtonD";
            this.AnswerButtonD.Padding = new System.Windows.Forms.Padding(10);
            this.AnswerButtonD.Primary = true;
            this.AnswerButtonD.Size = new System.Drawing.Size(300, 85);
            this.AnswerButtonD.TabIndex = 3;
            this.AnswerButtonD.Text = "Answer D";
            this.AnswerButtonD.UseVisualStyleBackColor = true;
            this.AnswerButtonD.Click += new System.EventHandler(this.AnswerButtonD_Click);
            // 
            // AnswerButtonB
            // 
            this.AnswerButtonB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerButtonB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnswerButtonB.Depth = 0;
            this.AnswerButtonB.Location = new System.Drawing.Point(329, 10);
            this.AnswerButtonB.Margin = new System.Windows.Forms.Padding(10);
            this.AnswerButtonB.MouseState = MaterialSkin.MouseState.HOVER;
            this.AnswerButtonB.Name = "AnswerButtonB";
            this.AnswerButtonB.Padding = new System.Windows.Forms.Padding(10);
            this.AnswerButtonB.Primary = true;
            this.AnswerButtonB.Size = new System.Drawing.Size(300, 85);
            this.AnswerButtonB.TabIndex = 1;
            this.AnswerButtonB.Text = "Answer B";
            this.AnswerButtonB.UseVisualStyleBackColor = true;
            this.AnswerButtonB.Click += new System.EventHandler(this.AnswerButtonB_Click);
            // 
            // AnswerButtonA
            // 
            this.AnswerButtonA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerButtonA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnswerButtonA.Depth = 0;
            this.AnswerButtonA.Location = new System.Drawing.Point(10, 10);
            this.AnswerButtonA.Margin = new System.Windows.Forms.Padding(10);
            this.AnswerButtonA.MouseState = MaterialSkin.MouseState.HOVER;
            this.AnswerButtonA.Name = "AnswerButtonA";
            this.AnswerButtonA.Padding = new System.Windows.Forms.Padding(10);
            this.AnswerButtonA.Primary = true;
            this.AnswerButtonA.Size = new System.Drawing.Size(299, 85);
            this.AnswerButtonA.TabIndex = 0;
            this.AnswerButtonA.Text = "Answer A";
            this.AnswerButtonA.UseVisualStyleBackColor = true;
            this.AnswerButtonA.Click += new System.EventHandler(this.AnswerButtonA_Click);
            // 
            // AnswerButtonC
            // 
            this.AnswerButtonC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerButtonC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnswerButtonC.Depth = 0;
            this.AnswerButtonC.Location = new System.Drawing.Point(10, 115);
            this.AnswerButtonC.Margin = new System.Windows.Forms.Padding(10);
            this.AnswerButtonC.MouseState = MaterialSkin.MouseState.HOVER;
            this.AnswerButtonC.Name = "AnswerButtonC";
            this.AnswerButtonC.Padding = new System.Windows.Forms.Padding(10);
            this.AnswerButtonC.Primary = true;
            this.AnswerButtonC.Size = new System.Drawing.Size(299, 85);
            this.AnswerButtonC.TabIndex = 2;
            this.AnswerButtonC.Text = "Answer C";
            this.AnswerButtonC.UseVisualStyleBackColor = true;
            this.AnswerButtonC.Click += new System.EventHandler(this.AnswerButtonC_Click);
            // 
            // InsideQuestionPanel
            // 
            this.InsideQuestionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InsideQuestionPanel.ColumnCount = 3;
            this.InsideQuestionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.InsideQuestionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InsideQuestionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.InsideQuestionPanel.Controls.Add(this.CounterLabel, 2, 0);
            this.InsideQuestionPanel.Controls.Add(this.ScoreLabel, 0, 0);
            this.InsideQuestionPanel.Controls.Add(this.QuestionLabel, 1, 0);
            this.InsideQuestionPanel.Location = new System.Drawing.Point(23, 23);
            this.InsideQuestionPanel.Name = "InsideQuestionPanel";
            this.InsideQuestionPanel.RowCount = 1;
            this.InsideQuestionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InsideQuestionPanel.Size = new System.Drawing.Size(639, 209);
            this.InsideQuestionPanel.TabIndex = 1;
            // 
            // CounterLabel
            // 
            this.CounterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CounterLabel.AutoSize = true;
            this.CounterLabel.Depth = 0;
            this.CounterLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.CounterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CounterLabel.Location = new System.Drawing.Point(556, 10);
            this.CounterLabel.Margin = new System.Windows.Forms.Padding(10);
            this.CounterLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(73, 38);
            this.CounterLabel.TabIndex = 3;
            this.CounterLabel.Text = "Time left:\r\n10";
            this.CounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Depth = 0;
            this.ScoreLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ScoreLabel.Location = new System.Drawing.Point(10, 10);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(10);
            this.ScoreLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(17, 19);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "0";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Depth = 0;
            this.QuestionLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.QuestionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QuestionLabel.Location = new System.Drawing.Point(110, 10);
            this.QuestionLabel.Margin = new System.Windows.Forms.Padding(10);
            this.QuestionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(419, 189);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "Question?";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WaitPanel
            // 
            this.WaitPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WaitPanel.AutoSize = true;
            this.WaitPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WaitPanel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.WaitPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.WaitPanel.Controls.Add(this.WaitLabel, 0, 0);
            this.WaitPanel.Location = new System.Drawing.Point(837, 56);
            this.WaitPanel.Name = "WaitPanel";
            this.WaitPanel.Padding = new System.Windows.Forms.Padding(20);
            this.WaitPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.WaitPanel.Size = new System.Drawing.Size(274, 79);
            this.WaitPanel.TabIndex = 4;
            // 
            // WaitLabel
            // 
            this.WaitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WaitLabel.AutoSize = true;
            this.WaitLabel.Depth = 0;
            this.WaitLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.WaitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WaitLabel.Location = new System.Drawing.Point(30, 30);
            this.WaitLabel.Margin = new System.Windows.Forms.Padding(10);
            this.WaitLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.WaitLabel.Name = "WaitLabel";
            this.WaitLabel.Size = new System.Drawing.Size(214, 19);
            this.WaitLabel.TabIndex = 2;
            this.WaitLabel.Text = "Waiting for the next question...";
            this.WaitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoresPanel
            // 
            this.ScoresPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScoresPanel.AutoSize = true;
            this.ScoresPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ScoresPanel.BackColor = System.Drawing.Color.Gold;
            this.ScoresPanel.ColumnCount = 1;
            this.ScoresPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ScoresPanel.Controls.Add(this.HomeButton, 0, 2);
            this.ScoresPanel.Controls.Add(this.ScoresLabel, 0, 0);
            this.ScoresPanel.Controls.Add(this.ScoresFlowPanel, 0, 1);
            this.ScoresPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.ScoresPanel.Location = new System.Drawing.Point(1030, 254);
            this.ScoresPanel.Name = "ScoresPanel";
            this.ScoresPanel.Padding = new System.Windows.Forms.Padding(20);
            this.ScoresPanel.RowCount = 3;
            this.ScoresPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ScoresPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ScoresPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ScoresPanel.Size = new System.Drawing.Size(178, 248);
            this.ScoresPanel.TabIndex = 5;
            // 
            // HomeButton
            // 
            this.HomeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HomeButton.AutoSize = true;
            this.HomeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.Depth = 0;
            this.HomeButton.Location = new System.Drawing.Point(62, 175);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(10);
            this.HomeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(10);
            this.HomeButton.Primary = true;
            this.HomeButton.Size = new System.Drawing.Size(54, 43);
            this.HomeButton.TabIndex = 7;
            this.HomeButton.Text = "Exit";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // ScoresLabel
            // 
            this.ScoresLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoresLabel.AutoSize = true;
            this.ScoresLabel.Depth = 0;
            this.ScoresLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ScoresLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ScoresLabel.Location = new System.Drawing.Point(30, 30);
            this.ScoresLabel.Margin = new System.Windows.Forms.Padding(10);
            this.ScoresLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ScoresLabel.Name = "ScoresLabel";
            this.ScoresLabel.Size = new System.Drawing.Size(118, 19);
            this.ScoresLabel.TabIndex = 5;
            this.ScoresLabel.Text = "Scores";
            this.ScoresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoresFlowPanel
            // 
            this.ScoresFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoresFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ScoresFlowPanel.Location = new System.Drawing.Point(23, 62);
            this.ScoresFlowPanel.Name = "ScoresFlowPanel";
            this.ScoresFlowPanel.Size = new System.Drawing.Size(132, 100);
            this.ScoresFlowPanel.TabIndex = 6;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ScoresPanel);
            this.Controls.Add(this.WaitPanel);
            this.Controls.Add(this.QuestionPanel);
            this.Controls.Add(this.IPPanel);
            this.Controls.Add(this.LobbyPanel);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientForm_KeyDown);
            this.Resize += new System.EventHandler(this.ClientForm_Resize);
            this.LobbyPanel.ResumeLayout(false);
            this.LobbyPanel.PerformLayout();
            this.IPPanel.ResumeLayout(false);
            this.IPPanel.PerformLayout();
            this.QuestionPanel.ResumeLayout(false);
            this.AnswersPanel.ResumeLayout(false);
            this.InsideQuestionPanel.ResumeLayout(false);
            this.InsideQuestionPanel.PerformLayout();
            this.WaitPanel.ResumeLayout(false);
            this.WaitPanel.PerformLayout();
            this.ScoresPanel.ResumeLayout(false);
            this.ScoresPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel IPPanel;
        private MaterialSkin.Controls.MaterialLabel LobbyLabel;
        private MaterialSkin.Controls.MaterialLabel EnterIPLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField IPTextBox;
        private System.Windows.Forms.TableLayoutPanel LobbyPanel;
        private System.Windows.Forms.TableLayoutPanel AnswersPanel;
        private MaterialSkin.Controls.MaterialRaisedButton AnswerButtonA;
        private System.Windows.Forms.TableLayoutPanel QuestionPanel;
        private System.Windows.Forms.TableLayoutPanel WaitPanel;
        private MaterialSkin.Controls.MaterialRaisedButton AnswerButtonD;
        private MaterialSkin.Controls.MaterialRaisedButton AnswerButtonB;
        private MaterialSkin.Controls.MaterialRaisedButton AnswerButtonC;
        private System.Windows.Forms.TableLayoutPanel InsideQuestionPanel;
        private MaterialSkin.Controls.MaterialLabel QuestionLabel;
        private MaterialSkin.Controls.MaterialLabel CounterLabel;
        private MaterialSkin.Controls.MaterialLabel ScoreLabel;
        private MaterialSkin.Controls.MaterialLabel WaitLabel;
        private System.Windows.Forms.TableLayoutPanel ScoresPanel;
        private MaterialSkin.Controls.MaterialLabel ScoresLabel;
        private System.Windows.Forms.FlowLayoutPanel ScoresFlowPanel;
        private MaterialSkin.Controls.MaterialRaisedButton HomeButton;
    }
}

