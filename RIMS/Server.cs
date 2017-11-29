using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RIMS
{
    class Server
    {
        public bool connected = false;
        public Server(Form1 form)
        {
            this.form = form;
        }
        private Form1 form;
        List<ClientHandler> clients = new List<ClientHandler>();

        public void Run()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 5000);
            
            try
            {
                listener.Start();
                connected = true;
                form.Info("Server up and running, waiting for messages...");
                while (connected)
                {
                    TcpClient c = listener.AcceptTcpClient();
                    ClientHandler newClient = new ClientHandler(c, this, form);
                    clients.Add(newClient);
                    form.connectedBox.Items.Add(newClient);
                    Thread clientThread = new Thread(newClient.Run);
                    clientThread.Start();
                }

            }
            catch (Exception ex)
            {
                form.Info(ex.Message);
            }

        }

        public void Broadcast(ClientHandler client, string message)
        {
            foreach (ClientHandler tmpClient in clients)
            {
                if (tmpClient != client)
                {
                    NetworkStream n = tmpClient.tcpclient.GetStream();
                    BinaryWriter w = new BinaryWriter(n);
                    w.Write(message);
                    w.Flush();
                }
                else if (clients.Count() == 1)
                {
                    NetworkStream n = tmpClient.tcpclient.GetStream();
                    BinaryWriter w = new BinaryWriter(n);
                    w.Write("Sorry, you are alone...");
                    w.Flush();
                }
            }
        }

        public void DisconnectClient(ClientHandler client)
        {
            clients.Remove(client);
            form.Info("Client X has left the building...");
            Broadcast(client, "Client X has left the building...");
        }
    }
}

