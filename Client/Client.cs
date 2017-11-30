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

namespace Client
{
    class Client
    {
        public TcpClient client;
        private Form1 form;
        public bool connected;
        Thread senderThread;
        Message message;

        public Client(Form1 form)
        {           
            message = new Message();
            this.form = form;
        }

        public void StartListen()
        {
            try
            {
                
                client = new TcpClient("192.168.25.80", 5000);
                senderThread = new Thread(Listen);
                senderThread.Start();
                message.Alias = form.txBxAlias.Text;
                message.Ip = GetLocalIP();

                Send(null, true);
            }
            catch (Exception e)
            {
                form.Invoke(new Action(() => { form.labelStatus.Text = $"Det gick inte att ansluta till servern {e.Message}"; }));
            }

            //Thread listenerThread = new Thread(Send);
            //listenerThread.Start();
        }

        public void Listen()
        {
            string message = "";

            try
            {
                form.Invoke(new Action(() => { form.labelStatus.Text = "Uppkopplad mot servern"; }));
                form.Invoke(new Action(() => { form.groupBoxConnect.Enabled = false; }));

                connected = true;
                while (connected)
                {
                    NetworkStream n = client.GetStream();
                    message = new BinaryReader(n).ReadString();
                    form.Invoke(new Action(() => { form.labelQuestion.Text = message; }));
                }
            }
            catch (Exception ex)
            {
                form.Invoke(new Action(() => { form.labelStatus.Text = "Något gick fel: " + ex.Message; }));
   
            }
            finally
            {
                if (senderThread != null)
                    senderThread.Abort();
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
                form.Invoke(new Action(() => { form.labelStatus.Text = "Något gick fel: " + ex.Message; }));
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


    }
}

