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
    public class Server
    {
        public bool connected = false;
        public Server(Form1 form)
        {
            this.form = form;
        }
        private Form1 form;
        public List<ClientHandler> clients = new List<ClientHandler>();

        public void Run()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 5000);

            try
            {
                listener.Start();
                connected = true;
                form.Info("Server up and running, waiting for messages...");
                form.connectionLight.BackColor = System.Drawing.Color.DarkGreen;
                form.serverStartButton.Enabled = false;

                while (connected)
                {
                    TcpClient c = listener.AcceptTcpClient();
                    ClientHandler newClient = new ClientHandler(c, this, form, false, false, ((IPEndPoint)c.Client.RemoteEndPoint).Address.ToString());
                    clients.Add(newClient);

                    Connected();
                    //form.connectedBox.Items.Add(((IPEndPoint)c.Client.RemoteEndPoint).Address.ToString());                    

                    Thread clientThread = new Thread(newClient.Run);
                    clientThread.Start();

                }

            }
            catch (Exception ex)
            {

                form.Info(ex.Message);
                form.serverStartButton.Enabled = true;

            }
            finally
            {
                if (listener != null)
                {
                    listener.Stop();
                    form.serverStartButton.Enabled = true;
                }
            }

        }

        public void Connected()
        {
            form.connectedBox.Items.Clear();
            foreach (var client in clients)
            {
                string ip = ((IPEndPoint)client.tcpclient.Client.RemoteEndPoint).Address.ToString();
                if (client.Alias == null)
                {
                    client.Alias = "Håkan";
                }
                var temp = form.connectedBox.Items.Add(ip);
                temp.Text = client.Alias;
                if (client.Yes)
                    temp.BackColor = System.Drawing.Color.Green;
                if (client.No)
                    temp.BackColor = System.Drawing.Color.Red;
            }
            form.connectedInfoBox.Text = clients.Count.ToString();
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
            Connected();
        }

    }
}

