namespace Client
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
            this.btnNO = new System.Windows.Forms.Button();
            this.btnYES = new System.Windows.Forms.Button();
            this.btnConnectToServer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.textBoxAlias = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxConnect = new System.Windows.Forms.GroupBox();
            this.groupBoxAnswer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxConnect.SuspendLayout();
            this.groupBoxAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNO
            // 
            this.btnNO.BackColor = System.Drawing.Color.Red;
            this.btnNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNO.Location = new System.Drawing.Point(223, 154);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(167, 92);
            this.btnNO.TabIndex = 19;
            this.btnNO.Text = "NO";
            this.btnNO.UseVisualStyleBackColor = false;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // btnYES
            // 
            this.btnYES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnYES.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYES.Location = new System.Drawing.Point(33, 154);
            this.btnYES.Name = "btnYES";
            this.btnYES.Size = new System.Drawing.Size(167, 92);
            this.btnYES.TabIndex = 18;
            this.btnYES.Text = "YES";
            this.btnYES.UseVisualStyleBackColor = false;
            this.btnYES.Click += new System.EventHandler(this.btnYES_Click);
            // 
            // btnConnectToServer
            // 
            this.btnConnectToServer.Location = new System.Drawing.Point(38, 147);
            this.btnConnectToServer.Name = "btnConnectToServer";
            this.btnConnectToServer.Size = new System.Drawing.Size(149, 56);
            this.btnConnectToServer.TabIndex = 17;
            this.btnConnectToServer.Text = "Connect to server";
            this.btnConnectToServer.UseVisualStyleBackColor = true;
            this.btnConnectToServer.Click += new System.EventHandler(this.btnConnectToServer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Alias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Server IP-adress";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Red;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.labelStatus.Location = new System.Drawing.Point(304, 66);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(134, 24);
            this.labelStatus.TabIndex = 10;
            this.labelStatus.Text = "Not connected";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(25, 49);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(158, 46);
            this.labelQuestion.TabIndex = 13;
            this.labelQuestion.Text = "FRÅGA";
            // 
            // textBoxAlias
            // 
            this.textBoxAlias.Location = new System.Drawing.Point(38, 103);
            this.textBoxAlias.Name = "textBoxAlias";
            this.textBoxAlias.Size = new System.Drawing.Size(149, 22);
            this.textBoxAlias.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 22);
            this.textBox2.TabIndex = 11;
            // 
            // groupBoxConnect
            // 
            this.groupBoxConnect.Controls.Add(this.btnConnectToServer);
            this.groupBoxConnect.Controls.Add(this.label3);
            this.groupBoxConnect.Controls.Add(this.label2);
            this.groupBoxConnect.Controls.Add(this.textBoxAlias);
            this.groupBoxConnect.Controls.Add(this.textBox2);
            this.groupBoxConnect.Location = new System.Drawing.Point(32, 35);
            this.groupBoxConnect.Name = "groupBoxConnect";
            this.groupBoxConnect.Size = new System.Drawing.Size(239, 241);
            this.groupBoxConnect.TabIndex = 20;
            this.groupBoxConnect.TabStop = false;
            this.groupBoxConnect.Text = "Connect to Server";
            // 
            // groupBoxAnswer
            // 
            this.groupBoxAnswer.Controls.Add(this.btnNO);
            this.groupBoxAnswer.Controls.Add(this.btnYES);
            this.groupBoxAnswer.Controls.Add(this.labelQuestion);
            this.groupBoxAnswer.Location = new System.Drawing.Point(32, 304);
            this.groupBoxAnswer.Name = "groupBoxAnswer";
            this.groupBoxAnswer.Size = new System.Drawing.Size(439, 284);
            this.groupBoxAnswer.TabIndex = 21;
            this.groupBoxAnswer.TabStop = false;
            this.groupBoxAnswer.Text = "Answer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxConnect);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.groupBoxAnswer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBoxConnect.ResumeLayout(false);
            this.groupBoxConnect.PerformLayout();
            this.groupBoxAnswer.ResumeLayout(false);
            this.groupBoxAnswer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.Button btnYES;
        private System.Windows.Forms.Button btnConnectToServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.TextBox textBoxAlias;
        internal System.Windows.Forms.GroupBox groupBoxConnect;
        internal System.Windows.Forms.GroupBox groupBoxAnswer;
        internal System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label1;
    }
}

