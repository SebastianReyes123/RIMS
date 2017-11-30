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
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (myClient.client != null)
            {
                myClient.client.Close();
                myClient.Send(null, false);
                myClient.connected = false;
            }
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            myClient.Send("false", true);
            //myClient.connected = false;
            //myClient.client.Close();
        }
    }
}
