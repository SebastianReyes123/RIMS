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
        public TcpClient client;
        private Form1 form;
        public bool connected;
        Thread senderThread;

        public Client(Form1 form)
        {
            this.form = form;
        }

        public void StartListen()
        {
            client = new TcpClient("192.168.25.118", 5000);

            senderThread = new Thread(Listen);
            senderThread.Start();

            //Thread listenerThread = new Thread(Send);
            //listenerThread.Start();
        }

        public void Listen()
        {
            string message = "";

            try
            {
                form.textBoxStatus.Text = "Uppkopplad mot servern";
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
                form.textBoxStatus.Text = "Något gick fel: " + ex.Message;
            }
            finally
            {
                if (senderThread != null)
                    senderThread.Abort();
            }
        }

        public void Send()
        {
            string message = "";

            try
            {
                NetworkStream n = client.GetStream();
                message = "yes";
                BinaryWriter w = new BinaryWriter(n);
                w.Write(message);
                w.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void WriteQuestion()
        {
            string message = "";
            
                NetworkStream n = client.GetStream();
                message = "yes";
                BinaryWriter w = new BinaryWriter(n);
                w.Write(message);
                w.Flush();
            message = new BinaryReader(n).ReadString();
            form.labelQuestion.Text = message;


        }
    }
}
