using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        Client myClient;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = true;
            myClient = new Client(this);
            groupBoxConnect.Enabled = true;
        }

        private void btnConnectToServer_Click(object sender, EventArgs e)
        {
            myClient.StartListen();
        }

        private void btnYES_Click(object sender, EventArgs e)
        {
            btnNO.BackColor = Color.Red;
            btnYES.BackColor = Color.LightGreen;     
            myClient.Send("true", true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectClient();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {     
            btnYES.BackColor = Color.Green;
            btnNO.BackColor = Color.PaleVioletRed;
            myClient.Send("false", true);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DisconnectClient();
            groupBoxConnect.Enabled = true;
            labelStatus.Text = "Frånkopplad";
        }

        private void DisconnectClient()
        {
            if (myClient.client != null)
            {
                myClient.client.Close();
                myClient.connected = false;
                myClient.Send(null, false);
            }
        }

    }

}
