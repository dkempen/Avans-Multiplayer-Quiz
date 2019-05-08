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
            this.QuestionCountLabel = new MaterialSkin.Controls.MaterialLabel();
            this.QuestionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.WaitPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WaitLabel = new MaterialSkin.Controls.MaterialLabel();
            this.LobbyPanel.SuspendLayout();
            this.IPPanel.SuspendLayout();
            this.QuestionPanel.SuspendLayout();
            this.AnswersPanel.SuspendLayout();
            this.InsideQuestionPanel.SuspendLayout();
            this.WaitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LobbyPanel
            // 
            this.LobbyPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LobbyPanel.AutoSize = true;
            this.LobbyPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LobbyPanel.BackColor = System.Drawing.Color.Orange;
            this.LobbyPanel.ColumnCount = 1;
            this.LobbyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 352F));
            this.LobbyPanel.Controls.Add(this.LobbyLabel, 0, 0);
            this.LobbyPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.LobbyPanel.Location = new System.Drawing.Point(344, 12);
            this.LobbyPanel.Name = "LobbyPanel";
            this.LobbyPanel.Padding = new System.Windows.Forms.Padding(20);
            this.LobbyPanel.RowCount = 1;
            this.LobbyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LobbyPanel.Size = new System.Drawing.Size(392, 79);
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
            this.LobbyLabel.Size = new System.Drawing.Size(332, 19);
            this.LobbyLabel.TabIndex = 1;
            this.LobbyLabel.Text = "Please wait until the host starts the game";
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
            this.IPPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.IPPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.IPPanel.Size = new System.Drawing.Size(178, 126);
            this.IPPanel.TabIndex = 2;
            // 
            // EnterIPLabel
            // 
            this.EnterIPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterIPLabel.AutoSize = true;
            this.EnterIPLabel.Depth = 0;
            this.EnterIPLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.EnterIPLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EnterIPLabel.Location = new System.Drawing.Point(30, 30);
            this.EnterIPLabel.Margin = new System.Windows.Forms.Padding(10);
            this.EnterIPLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.EnterIPLabel.Name = "EnterIPLabel";
            this.EnterIPLabel.Size = new System.Drawing.Size(118, 23);
            this.EnterIPLabel.TabIndex = 5;
            this.EnterIPLabel.Text = "Enter IP address";
            this.EnterIPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IPTextBox
            // 
            this.IPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IPTextBox.Depth = 0;
            this.IPTextBox.Hint = "123.123.123.12";
            this.IPTextBox.Location = new System.Drawing.Point(30, 73);
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
            this.QuestionPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.QuestionPanel.ColumnCount = 1;
            this.QuestionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.QuestionPanel.Controls.Add(this.AnswersPanel, 0, 1);
            this.QuestionPanel.Controls.Add(this.InsideQuestionPanel, 0, 0);
            this.QuestionPanel.Location = new System.Drawing.Point(263, 138);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Padding = new System.Windows.Forms.Padding(20);
            this.QuestionPanel.RowCount = 2;
            this.QuestionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.59625F));
            this.QuestionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.40375F));
            this.QuestionPanel.Size = new System.Drawing.Size(714, 476);
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
            this.AnswersPanel.Location = new System.Drawing.Point(23, 243);
            this.AnswersPanel.Name = "AnswersPanel";
            this.AnswersPanel.RowCount = 2;
            this.AnswersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AnswersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AnswersPanel.Size = new System.Drawing.Size(668, 210);
            this.AnswersPanel.TabIndex = 0;
            // 
            // AnswerButtonD
            // 
            this.AnswerButtonD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerButtonD.Depth = 0;
            this.AnswerButtonD.Location = new System.Drawing.Point(344, 115);
            this.AnswerButtonD.Margin = new System.Windows.Forms.Padding(10);
            this.AnswerButtonD.MouseState = MaterialSkin.MouseState.HOVER;
            this.AnswerButtonD.Name = "AnswerButtonD";
            this.AnswerButtonD.Primary = true;
            this.AnswerButtonD.Size = new System.Drawing.Size(314, 85);
            this.AnswerButtonD.TabIndex = 3;
            this.AnswerButtonD.Text = "Answer D";
            this.AnswerButtonD.UseVisualStyleBackColor = true;
            // 
            // AnswerButtonB
            // 
            this.AnswerButtonB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerButtonB.Depth = 0;
            this.AnswerButtonB.Location = new System.Drawing.Point(344, 10);
            this.AnswerButtonB.Margin = new System.Windows.Forms.Padding(10);
            this.AnswerButtonB.MouseState = MaterialSkin.MouseState.HOVER;
            this.AnswerButtonB.Name = "AnswerButtonB";
            this.AnswerButtonB.Primary = true;
            this.AnswerButtonB.Size = new System.Drawing.Size(314, 85);
            this.AnswerButtonB.TabIndex = 1;
            this.AnswerButtonB.Text = "Answer B";
            this.AnswerButtonB.UseVisualStyleBackColor = true;
            // 
            // AnswerButtonA
            // 
            this.AnswerButtonA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerButtonA.Depth = 0;
            this.AnswerButtonA.Location = new System.Drawing.Point(10, 10);
            this.AnswerButtonA.Margin = new System.Windows.Forms.Padding(10);
            this.AnswerButtonA.MouseState = MaterialSkin.MouseState.HOVER;
            this.AnswerButtonA.Name = "AnswerButtonA";
            this.AnswerButtonA.Primary = true;
            this.AnswerButtonA.Size = new System.Drawing.Size(314, 85);
            this.AnswerButtonA.TabIndex = 0;
            this.AnswerButtonA.Text = "Answer A";
            this.AnswerButtonA.UseVisualStyleBackColor = true;
            // 
            // AnswerButtonC
            // 
            this.AnswerButtonC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerButtonC.Depth = 0;
            this.AnswerButtonC.Location = new System.Drawing.Point(10, 115);
            this.AnswerButtonC.Margin = new System.Windows.Forms.Padding(10);
            this.AnswerButtonC.MouseState = MaterialSkin.MouseState.HOVER;
            this.AnswerButtonC.Name = "AnswerButtonC";
            this.AnswerButtonC.Primary = true;
            this.AnswerButtonC.Size = new System.Drawing.Size(314, 85);
            this.AnswerButtonC.TabIndex = 2;
            this.AnswerButtonC.Text = "Answer C";
            this.AnswerButtonC.UseVisualStyleBackColor = true;
            // 
            // InsideQuestionPanel
            // 
            this.InsideQuestionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InsideQuestionPanel.ColumnCount = 3;
            this.InsideQuestionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.InsideQuestionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InsideQuestionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.InsideQuestionPanel.Controls.Add(this.CounterLabel, 2, 0);
            this.InsideQuestionPanel.Controls.Add(this.QuestionCountLabel, 0, 0);
            this.InsideQuestionPanel.Controls.Add(this.QuestionLabel, 1, 0);
            this.InsideQuestionPanel.Location = new System.Drawing.Point(23, 23);
            this.InsideQuestionPanel.Name = "InsideQuestionPanel";
            this.InsideQuestionPanel.RowCount = 1;
            this.InsideQuestionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InsideQuestionPanel.Size = new System.Drawing.Size(668, 214);
            this.InsideQuestionPanel.TabIndex = 1;
            // 
            // CounterLabel
            // 
            this.CounterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CounterLabel.AutoSize = true;
            this.CounterLabel.Depth = 0;
            this.CounterLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.CounterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CounterLabel.Location = new System.Drawing.Point(585, 10);
            this.CounterLabel.Margin = new System.Windows.Forms.Padding(10);
            this.CounterLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(73, 38);
            this.CounterLabel.TabIndex = 3;
            this.CounterLabel.Text = "Time left:\r\n10";
            this.CounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuestionCountLabel
            // 
            this.QuestionCountLabel.AutoSize = true;
            this.QuestionCountLabel.Depth = 0;
            this.QuestionCountLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.QuestionCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QuestionCountLabel.Location = new System.Drawing.Point(10, 10);
            this.QuestionCountLabel.Margin = new System.Windows.Forms.Padding(10);
            this.QuestionCountLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.QuestionCountLabel.Name = "QuestionCountLabel";
            this.QuestionCountLabel.Size = new System.Drawing.Size(39, 19);
            this.QuestionCountLabel.TabIndex = 2;
            this.QuestionCountLabel.Text = "3/12";
            this.QuestionCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.QuestionLabel.Location = new System.Drawing.Point(70, 10);
            this.QuestionLabel.Margin = new System.Windows.Forms.Padding(10);
            this.QuestionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(494, 194);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "Question?";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WaitPanel
            // 
            this.WaitPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WaitPanel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.WaitPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.WaitPanel.Controls.Add(this.WaitLabel, 0, 0);
            this.WaitPanel.Location = new System.Drawing.Point(1015, 138);
            this.WaitPanel.Name = "WaitPanel";
            this.WaitPanel.Padding = new System.Windows.Forms.Padding(20);
            this.WaitPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.WaitPanel.Size = new System.Drawing.Size(200, 100);
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
            this.WaitLabel.Size = new System.Drawing.Size(140, 40);
            this.WaitLabel.TabIndex = 2;
            this.WaitLabel.Text = "Waiting for the next question...";
            this.WaitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
        private MaterialSkin.Controls.MaterialLabel QuestionCountLabel;
        private MaterialSkin.Controls.MaterialLabel WaitLabel;
    }
}

