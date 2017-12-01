namespace RIMS
{
    partial class Form1
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
            this.serverStartButton = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.connectedInfoBox = new System.Windows.Forms.TextBox();
            this.connectionLight = new System.Windows.Forms.Button();
            this.connectedLabel = new System.Windows.Forms.Label();
            this.connectedBox = new System.Windows.Forms.ListView();
            this.textBoxAskQuestion = new System.Windows.Forms.TextBox();
            this.buttonSendQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelClientReplyStatus = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serverStartButton
            // 
            this.serverStartButton.Location = new System.Drawing.Point(349, 17);
            this.serverStartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serverStartButton.Name = "serverStartButton";
            this.serverStartButton.Size = new System.Drawing.Size(63, 24);
            this.serverStartButton.TabIndex = 0;
            this.serverStartButton.Text = "Host";
            this.serverStartButton.UseVisualStyleBackColor = true;
            this.serverStartButton.Click += new System.EventHandler(this.serverStartButton_Click);
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(9, 20);
            this.infoBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.Size = new System.Drawing.Size(295, 20);
            this.infoBox.TabIndex = 2;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(7, 4);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(58, 13);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = "Server info";
            // 
            // connectedInfoBox
            // 
            this.connectedInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.connectedInfoBox.Location = new System.Drawing.Point(712, 88);
            this.connectedInfoBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connectedInfoBox.Name = "connectedInfoBox";
            this.connectedInfoBox.ReadOnly = true;
            this.connectedInfoBox.Size = new System.Drawing.Size(25, 13);
            this.connectedInfoBox.TabIndex = 5;
            // 
            // connectionLight
            // 
            this.connectionLight.BackColor = System.Drawing.Color.Red;
            this.connectionLight.Location = new System.Drawing.Point(308, 20);
            this.connectionLight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connectionLight.Name = "connectionLight";
            this.connectionLight.Size = new System.Drawing.Size(26, 18);
            this.connectionLight.TabIndex = 6;
            this.connectionLight.UseVisualStyleBackColor = false;
            // 
            // connectedLabel
            // 
            this.connectedLabel.AutoSize = true;
            this.connectedLabel.Location = new System.Drawing.Point(623, 89);
            this.connectedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.connectedLabel.Name = "connectedLabel";
            this.connectedLabel.Size = new System.Drawing.Size(85, 13);
            this.connectedLabel.TabIndex = 7;
            this.connectedLabel.Text = "Anslutna klienter";
            // 
            // connectedBox
            // 
            this.connectedBox.AllowColumnReorder = true;
            this.connectedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedBox.FullRowSelect = true;
            this.connectedBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.connectedBox.LabelWrap = false;
            this.connectedBox.Location = new System.Drawing.Point(626, 105);
            this.connectedBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connectedBox.Name = "connectedBox";
            this.connectedBox.Size = new System.Drawing.Size(113, 385);
            this.connectedBox.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.connectedBox.TabIndex = 8;
            this.connectedBox.Tag = "";
            this.connectedBox.TileSize = new System.Drawing.Size(100, 100);
            this.connectedBox.UseCompatibleStateImageBehavior = false;
            this.connectedBox.View = System.Windows.Forms.View.List;
            // 
            // textBoxAskQuestion
            // 
            this.textBoxAskQuestion.Location = new System.Drawing.Point(9, 125);
            this.textBoxAskQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAskQuestion.Name = "textBoxAskQuestion";
            this.textBoxAskQuestion.Size = new System.Drawing.Size(325, 20);
            this.textBoxAskQuestion.TabIndex = 8;
            this.textBoxAskQuestion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAskQuestion_KeyDown);
            // 
            // buttonSendQuestion
            // 
            this.buttonSendQuestion.Location = new System.Drawing.Point(349, 125);
            this.buttonSendQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSendQuestion.Name = "buttonSendQuestion";
            this.buttonSendQuestion.Size = new System.Drawing.Size(90, 19);
            this.buttonSendQuestion.TabIndex = 9;
            this.buttonSendQuestion.Text = "Skicka fråga";
            this.buttonSendQuestion.UseVisualStyleBackColor = true;
            this.buttonSendQuestion.Click += new System.EventHandler(this.buttonSendQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ställ en fråga";
            // 
            // labelClientReplyStatus
            // 
            this.labelClientReplyStatus.AutoSize = true;
            this.labelClientReplyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientReplyStatus.Location = new System.Drawing.Point(12, 375);
            this.labelClientReplyStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClientReplyStatus.Name = "labelClientReplyStatus";
            this.labelClientReplyStatus.Size = new System.Drawing.Size(173, 55);
            this.labelClientReplyStatus.TabIndex = 11;
            this.labelClientReplyStatus.Text = "Status:";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(9, 246);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(176, 55);
            this.labelQuestion.TabIndex = 12;
            this.labelQuestion.Text = "Fråga: ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 181);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(242, 19);
            this.progressBar1.TabIndex = 13;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            // 
            // labelPercentage
            // 
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.Location = new System.Drawing.Point(224, 163);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(13, 13);
            this.labelPercentage.TabIndex = 14;
            this.labelPercentage.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 519);
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.labelClientReplyStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSendQuestion);
            this.Controls.Add(this.textBoxAskQuestion);
            this.Controls.Add(this.connectedLabel);
            this.Controls.Add(this.connectionLight);
            this.Controls.Add(this.connectedInfoBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.connectedBox);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.serverStartButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label infoLabel;
        public System.Windows.Forms.TextBox connectedInfoBox;        
        public System.Windows.Forms.Button connectionLight;
        public System.Windows.Forms.Button serverStartButton;
        private System.Windows.Forms.Label connectedLabel;
        public System.Windows.Forms.ListView connectedBox;
        public System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.TextBox textBoxAskQuestion;
        private System.Windows.Forms.Button buttonSendQuestion;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label labelClientReplyStatus;
        internal System.Windows.Forms.Label labelQuestion;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelPercentage;
    }
}

