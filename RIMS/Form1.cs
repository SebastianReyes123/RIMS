using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
                Server.connected = false;
                TcpClient client = new TcpClient("127.0.0.1", 5000);
                NetworkStream n = client.GetStream();
                BinaryWriter w = new BinaryWriter(n);
                w.Write("OBS. Skickas inte till någon. Bara för att avsluta denna tråd");
                w.Flush();

                myServer.Broadcast("Servern has stängts", false);   
            }
        }
        
        private void buttonSendQuestion_Click(object sender, EventArgs e)
        {
            myServer.Broadcast(textBoxAskQuestion.Text, true);
        }        
    }
}
