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
using System.Windows.Forms;
using System.Drawing;


namespace RIMS
{
    public class Server
    {
        public static bool connected = false;
        public TcpClient client;
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
                form.infoBox.Text = "Server up and running...";
                form.connectionLight.BackColor = Color.DarkGreen;
                form.serverStartButton.Enabled = false;

                while (connected)
                {
                    TcpClient c = listener.AcceptTcpClient();
                    ClientHandler newClient = new ClientHandler(c, this, form, false, false, ((IPEndPoint)c.Client.RemoteEndPoint).Address.ToString());
                    clients.Add(newClient);
                    Broadcast(form.labelQuestion.Text, true);
                    Connected();

                    Thread clientThread = new Thread(newClient.Run);
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {

                form.infoBox.Text = ex.Message;
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
            int clientsConnected = 0;
            int clientsReplied = 0;

            foreach (var client in clients)
            {
                clientsConnected++;
                string ip = ((IPEndPoint)client.tcpclient.Client.RemoteEndPoint).Address.ToString();
                if (client.Alias == null || client.Alias == string.Empty)
                {
                    client.Alias = "Håkan";
                }
                var temp = form.connectedBox.Items.Add(ip);
                temp.Text = client.Alias;
                if (client.Yes)
                {
                    temp.BackColor = Color.Green;
                    clientsReplied++;
                }

                if (client.No)
                {
                    temp.BackColor = Color.Red;
                    clientsReplied++;
                }
            }

            form.labelClientReplyStatus.Text = $"Svarat: {clientsReplied} / {clientsConnected}";
            form.connectedInfoBox.Text = clients.Count.ToString();
            form.progressBar1.PerformStep();
            
        }



        public void Broadcast(string message, bool isConnected)
        {
            foreach (ClientHandler tmpClient in clients)
            {
                NetworkStream n = tmpClient.tcpclient.GetStream();
                BinaryWriter w = new BinaryWriter(n);
                string hostMessage = JsonConvert.SerializeObject(new HostMessage { Message = message, IsConnected = isConnected });
                w.Write(hostMessage);
                w.Flush();

                
                Connected();
            }
        }

        public void DisconnectClient(ClientHandler client)
        {
            clients.Remove(client);
            form.infoBox.Text = $"Client {client.Alias} has left the building...";
            Connected();

        }
    }


}


