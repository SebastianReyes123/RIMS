﻿namespace Client
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
            this.txBxAlias = new System.Windows.Forms.TextBox();
            this.txBxIp = new System.Windows.Forms.TextBox();
            this.groupBoxConnect = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.groupBoxConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNO
            // 
            this.btnNO.BackColor = System.Drawing.Color.Red;
            this.btnNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNO.Location = new System.Drawing.Point(261, 442);
            this.btnNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(210, 111);
            this.btnNO.TabIndex = 19;
            this.btnNO.Text = "NO";
            this.btnNO.UseVisualStyleBackColor = false;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // btnYES
            // 
            this.btnYES.BackColor = System.Drawing.Color.Green;
            this.btnYES.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYES.Location = new System.Drawing.Point(23, 442);
            this.btnYES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYES.Name = "btnYES";
            this.btnYES.Size = new System.Drawing.Size(210, 111);
            this.btnYES.TabIndex = 18;
            this.btnYES.Text = "YES";
            this.btnYES.UseVisualStyleBackColor = false;
            this.btnYES.Click += new System.EventHandler(this.btnYES_Click);
            // 
            // btnConnectToServer
            // 
            this.btnConnectToServer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConnectToServer.Location = new System.Drawing.Point(9, 129);
            this.btnConnectToServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnectToServer.Name = "btnConnectToServer";
            this.btnConnectToServer.Size = new System.Drawing.Size(149, 49);
            this.btnConnectToServer.TabIndex = 17;
            this.btnConnectToServer.Text = "Connect to server";
            this.btnConnectToServer.UseVisualStyleBackColor = false;
            this.btnConnectToServer.Click += new System.EventHandler(this.btnConnectToServer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Alias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Server IP-adress";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelStatus.Location = new System.Drawing.Point(290, 26);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 20);
            this.labelStatus.TabIndex = 14;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(17, 325);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(0, 32);
            this.labelQuestion.TabIndex = 13;
            // 
            // txBxAlias
            // 
            this.txBxAlias.Location = new System.Drawing.Point(9, 85);
            this.txBxAlias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txBxAlias.Name = "txBxAlias";
            this.txBxAlias.Size = new System.Drawing.Size(149, 22);
            this.txBxAlias.TabIndex = 12;
            // 
            // txBxIp
            // 
            this.txBxIp.Location = new System.Drawing.Point(9, 39);
            this.txBxIp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txBxIp.Name = "txBxIp";
            this.txBxIp.Size = new System.Drawing.Size(149, 22);
            this.txBxIp.TabIndex = 11;
            this.txBxIp.Text = "192.168.25.";
            // 
            // groupBoxConnect
            // 
            this.groupBoxConnect.Controls.Add(this.label2);
            this.groupBoxConnect.Controls.Add(this.txBxIp);
            this.groupBoxConnect.Controls.Add(this.btnConnectToServer);
            this.groupBoxConnect.Controls.Add(this.txBxAlias);
            this.groupBoxConnect.Controls.Add(this.label3);
            this.groupBoxConnect.Location = new System.Drawing.Point(13, 13);
            this.groupBoxConnect.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxConnect.Name = "groupBoxConnect";
            this.groupBoxConnect.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxConnect.Size = new System.Drawing.Size(184, 184);
            this.groupBoxConnect.TabIndex = 20;
            this.groupBoxConnect.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Status";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.Salmon;
            this.btnDisconnect.Location = new System.Drawing.Point(23, 205);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(99, 35);
            this.btnDisconnect.TabIndex = 22;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(529, 631);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnYES);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.groupBoxConnect);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBoxConnect.ResumeLayout(false);
            this.groupBoxConnect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConnectToServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label labelQuestion;
        public System.Windows.Forms.TextBox txBxAlias;
        public System.Windows.Forms.GroupBox groupBoxConnect;
        public System.Windows.Forms.Label labelStatus;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txBxIp;
        private System.Windows.Forms.Button btnDisconnect;
        internal System.Windows.Forms.Button btnNO;
        internal System.Windows.Forms.Button btnYES;
    }
}

