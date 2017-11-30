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
            //CheckForIllegalCrossThreadCalls = false;
            myClient = new Client(this);
            groupBoxConnect.Enabled = true;
        }

        private void btnConnectToServer_Click(object sender, EventArgs e)
        {
            myClient.StartListen();
        }

        private void btnYES_Click(object sender, EventArgs e)
        {
            myClient.Send("true", true);
            btnNO.BackColor = Color.Red;
            btnYES.BackColor = Color.LightGreen;
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            DisconnectClient();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {     
            myClient.Send("false", true);
            btnYES.BackColor = Color.Green;
            btnNO.BackColor = Color.PaleVioletRed;

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
                myClient.Send(null, false);
                myClient.connected = false;
            }
        }

    }

}
