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
            CheckForIllegalCrossThreadCalls = true;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
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
                w.Flush();// den här är bara shu

                myServer.Broadcast("Servern has stängts", false);
            }
        }

        private void buttonSendQuestion_Click(object sender, EventArgs e)
        {
            BroadcastQuestion();
        }

        private void textBoxAskQuestion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                BroadcastQuestion();
            }
        }
        private void BroadcastQuestion()
        {
            foreach (var client in myServer.clients)
            {
                client.No = false;
                client.Yes = false;
            }
            textBoxQuestion.Text = textBoxAskQuestion.Text;
            myServer.Broadcast(textBoxAskQuestion.Text, true);
            myServer.Connected();
        }

        public void Progress()
        {
            double yesCounter = 0;
            double noCounter = 0;

            if (myServer != null)
            {
                foreach (var item in myServer.clients)
                {
                    if (item.Yes)
                    {
                        yesCounter++;
                    }
                    if (item.No)
                    {
                        noCounter++;
                    }
                }
                if (yesCounter > 0 || noCounter > 0)
                {
                    double progress = (yesCounter / (yesCounter + noCounter)) * 100;
                    progressBar1.Value = (int)progress;
                    progressBar1.BackColor = Color.Red;

                    labelPercentage.Text = $"JA: {progress}% NEJ: {100-progress}%";
                }
                else if (yesCounter == 0 && noCounter == 0)
                {
                    progressBar1.Value = 0;
                    labelPercentage.Text = "0 %";
                    progressBar1.BackColor = Color.AntiqueWhite;
                }
            }
        }
    }
}
