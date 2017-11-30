﻿namespace RIMS
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("192.168.0.1");
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "192.168.0.2"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Green, null);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("", System.Windows.Forms.HorizontalAlignment.Left);
            this.serverStartButton = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.connectedInfoBox = new System.Windows.Forms.TextBox();
            this.connectionLight = new System.Windows.Forms.Button();
            this.connectedLabel = new System.Windows.Forms.Label();
            this.connectedBox = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // serverStartButton
            // 
            this.serverStartButton.Location = new System.Drawing.Point(465, 21);
            this.serverStartButton.Name = "serverStartButton";
            this.serverStartButton.Size = new System.Drawing.Size(84, 30);
            this.serverStartButton.TabIndex = 0;
            this.serverStartButton.Text = "Host";
            this.serverStartButton.UseVisualStyleBackColor = true;
            this.serverStartButton.Click += new System.EventHandler(this.serverStartButton_Click);
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(12, 25);
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.Size = new System.Drawing.Size(392, 22);
            this.infoBox.TabIndex = 2;           
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(13, 2);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(73, 17);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = "Info/status";
            // 
            // connectedInfoBox
            // 
            this.connectedInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.connectedInfoBox.Location = new System.Drawing.Point(921, 108);
            this.connectedInfoBox.Name = "connectedInfoBox";
            this.connectedInfoBox.ReadOnly = true;
            this.connectedInfoBox.Size = new System.Drawing.Size(43, 15);
            this.connectedInfoBox.TabIndex = 5;
            // 
            // connectionLight
            // 
            this.connectionLight.BackColor = System.Drawing.Color.Red;
            this.connectionLight.Location = new System.Drawing.Point(410, 25);
            this.connectionLight.Name = "connectionLight";
            this.connectionLight.Size = new System.Drawing.Size(34, 22);
            this.connectionLight.TabIndex = 6;
            this.connectionLight.UseVisualStyleBackColor = false;
            // 
            // connectedLabel
            // 
            this.connectedLabel.AutoSize = true;
            this.connectedLabel.Location = new System.Drawing.Point(802, 108);
            this.connectedLabel.Name = "connectedLabel";
            this.connectedLabel.Size = new System.Drawing.Size(113, 17);
            this.connectedLabel.TabIndex = 7;
            this.connectedLabel.Text = "Anslutna klienter";
            // 
            // connectedBox
            // 
            this.connectedBox.AllowColumnReorder = true;
            this.connectedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedBox.FullRowSelect = true;
            this.connectedBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewGroup1.Header = "";
            listViewGroup1.Name = "listViewGroup1";
            listViewItem1.Group = listViewGroup1;
            listViewGroup2.Header = "";
            listViewGroup2.Name = "listViewGroup2";
            listViewItem2.Group = listViewGroup2;
            this.connectedBox.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.connectedBox.LabelWrap = false;
            this.connectedBox.Location = new System.Drawing.Point(867, 129);
            this.connectedBox.Name = "connectedBox";
            this.connectedBox.Size = new System.Drawing.Size(116, 473);
            this.connectedBox.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.connectedBox.TabIndex = 8;
            this.connectedBox.Tag = "";
            this.connectedBox.TileSize = new System.Drawing.Size(100, 100);
            this.connectedBox.UseCompatibleStateImageBehavior = false;
            this.connectedBox.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 639);
            this.Controls.Add(this.connectedLabel);
            this.Controls.Add(this.connectionLight);
            this.Controls.Add(this.connectedInfoBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.connectedBox);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.serverStartButton);
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
    }
}

