using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Drawing;

namespace Client
{
    class Client
    {
        public TcpClient client;
        public bool connected;
        private Form1 form;
        private Message message;

        public Client(Form1 form)
        {
            message = new Message();
            this.form = form;
        }

        public void StartListen()
        {
            try
            {
                //IP nr hårdkodat - ÄNDRA!
                client = new TcpClient("192.168.25.164", 5000);

                message.Alias = form.textBoxAlias.Text;
                message.IP = GetLocalIP();
                Send(null, true);
                Thread senderThread = new Thread(Listen);
                senderThread.Start();
            }
            catch (Exception e)
            {
                form.Invoke(new Action(() => form.labelStatus.Text = "Något gick fel. " + e.Message));
            }
        }

        public void Listen()
        {
            string message = "";

            try
            {
                form.labelStatus.Text = "Connected";
                form.labelStatus.BackColor = Color.FromArgb(0, 128, 0);
                form.Invoke(new Action(() => form.groupBoxConnect.Hide()));
                form.Invoke(new Action(() => form.groupBoxAnswer.Show()));
                connected = true;
                while (connected)
                {
                    NetworkStream n = client.GetStream();
                    message = new BinaryReader(n).ReadString();
                    form.labelQuestion.Text = message;
                }
            }
            catch (Exception ex)
            {
                form.labelStatus.Text = "Något gick fel: " + ex.Message;
            }
        }

        public void Send(string answer, bool stayConnect)
        {
            message.Answer = answer;
            message.StayConnected = stayConnect;
            try
            {
                NetworkStream n = client.GetStream();
                BinaryWriter w = new BinaryWriter(n);
                string jsonMessage = JsonConvert.SerializeObject(message);
                w.Write(jsonMessage);
                w.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }
    }
}
