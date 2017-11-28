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
            this.replyButton = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.connectedBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // serverStartButton
            // 
            this.serverStartButton.Location = new System.Drawing.Point(572, 76);
            this.serverStartButton.Name = "serverStartButton";
            this.serverStartButton.Size = new System.Drawing.Size(209, 96);
            this.serverStartButton.TabIndex = 0;
            this.serverStartButton.Text = "Start server";
            this.serverStartButton.UseVisualStyleBackColor = true;
            this.serverStartButton.Click += new System.EventHandler(this.serverStartButton_Click);
            // 
            // replyButton
            // 
            this.replyButton.Location = new System.Drawing.Point(375, 259);
            this.replyButton.Name = "replyButton";
            this.replyButton.Size = new System.Drawing.Size(229, 124);
            this.replyButton.TabIndex = 1;
            this.replyButton.Text = "Ready?";
            this.replyButton.UseVisualStyleBackColor = true;
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(81, 48);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(392, 22);
            this.infoBox.TabIndex = 2;
            this.infoBox.TextChanged += new System.EventHandler(this.infoBox_TextChanged);
            // 
            // connectedBox
            // 
            this.connectedBox.FormattingEnabled = true;
            this.connectedBox.ItemHeight = 16;
            this.connectedBox.Location = new System.Drawing.Point(64, 104);
            this.connectedBox.Name = "connectedBox";
            this.connectedBox.Size = new System.Drawing.Size(120, 212);
            this.connectedBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 639);
            this.Controls.Add(this.connectedBox);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.replyButton);
            this.Controls.Add(this.serverStartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button serverStartButton;
        private System.Windows.Forms.Button replyButton;
        private System.Windows.Forms.TextBox infoBox;
        public System.Windows.Forms.ListBox connectedBox;
    }
}

