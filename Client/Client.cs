using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RIMS;
using System.Drawing;

namespace Client
{
    class Client
    {
        public TcpClient client;
        private Form1 form;
        public bool connected;
        Thread senderThread;
        Message message;
        string Ip;

        public Client(Form1 form)
        {
            message = new Message();
            this.form = form;
        }

        public void StartListen()
        {
            try
            {
                form.Invoke(new Action(() => { Ip = form.txBxIp.Text; }));

                client = new TcpClient();
                SetStatusLabelText("Försöker ansluta..", Color.Black);

                if (client.ConnectAsync(Ip, 5000).Wait(3000))
                {
                    senderThread = new Thread(Listen);
                    senderThread.Start();
                    message.Alias = form.txBxAlias.Text;
                    message.Ip = GetLocalIP();
                    Send(null, true);
                }
                
            }
            catch (Exception e)
            {
                SetStatusLabelText("Det gick ej att ansluta", Color.Red);
                GroupBoxEnabler(true);
            }      
        }

        public void Listen()
        {
            try
            {
                SetStatusLabelText("Uppkopplad mot servern", Color.Green);
                GroupBoxEnabler(false);


                connected = true;
                while (connected)
                {
                    NetworkStream n = client.GetStream();
                    string message = new BinaryReader(n).ReadString();
                    var msg = JsonConvert.DeserializeObject<HostMessage>(message);

                    if (!msg.IsConnected)
                    {
                        GroupBoxEnabler(true);
                        SetStatusLabelText("Ej ansluten till server", Color.Red);
                        connected = false;
                    }
                    else
                    {
                        form.Invoke(new Action(() => { form.labelQuestion.Text = msg.Message; }));
                        form.Invoke(new Action(() => { form.btnYES.BackColor = Color.Green; }));
                        form.Invoke(new Action(() => { form.btnNO.BackColor = Color.Red; }));
                    }
                }
            }
            catch (Exception ex)
            {
                SetStatusLabelText("Något gick fel vid försök att ta emot ett meddelande från servern", Color.Red);
                GroupBoxEnabler(true);

            }
        }

        public void Send(string answer, bool stayConnected)
        {
            message.StayConnected = stayConnected;
            message.Answer = answer;

            try
            {
                NetworkStream n = client.GetStream();
                BinaryWriter w = new BinaryWriter(n);
                var msg = JsonConvert.SerializeObject(message);
                w.Write(msg);
                w.Flush();
            }
            catch (Exception ex)
            {
                SetStatusLabelText("Svaret kunde ej skickas till servern", Color.Red);
                form.Invoke(new Action(() => { form.btnYES.BackColor = Color.Green; }));
                form.Invoke(new Action(() => { form.btnNO.BackColor = Color.Red; }));
            }
        }

        public string GetLocalIP()
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

        public void GroupBoxEnabler(bool b)
        {           
                form.Invoke(new Action(() => { form.groupBoxConnect.Enabled = b; }));
        }

        public void SetStatusLabelText(string status, Color color)
        {
                form.labelStatus.BackColor = color;
                form.Invoke(new Action(() => { form.labelStatus.Text = status; }));       
        }
    }
}

