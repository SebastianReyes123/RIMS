using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIMS
{
    public partial class Form1 : Form
    {
        Server myServer;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }
        public void Info(string info)
        {
            infoBox.Text = info;
        }

        private void infoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void serverStartButton_Click(object sender, EventArgs e)
        {
            myServer = new Server(this);
            Thread serverThread = new Thread(myServer.Run);
            serverThread.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myServer != null)
            {
                myServer.connected = false;
                TcpClient client = new TcpClient("127.0.0.1", 5000);
                NetworkStream n = client.GetStream();
                BinaryWriter w = new BinaryWriter(n);
                w.Write("quit");
                w.Flush();
            }
        }
    }
}
