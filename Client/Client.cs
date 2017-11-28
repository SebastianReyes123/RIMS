using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    class Client
    {
        private TcpClient client;
        private Form1 form;
        private bool userReady;

        public Client(Form1 form)
        {
            this.form = form;
        }

        public void StartListen()
        {
            client = new TcpClient("192.168.25.89", 5000);
            Thread senderThread = new Thread(Listen);
            senderThread.Start();
        }

        public void Listen()
        {
            string message = "";

            try
            {
                form.textBoxStatus.Text = "Uppkopplad mot servern";
                while (true)
                {
                    NetworkStream n = client.GetStream();
                    message = new BinaryReader(n).ReadString();
                    form.labelQuestion.Text = message;
                }
            }
            catch (Exception ex)
            {
                form.textBoxStatus.Text = "Något gick fel: " + ex.Message;
            }
        }

    }
}
