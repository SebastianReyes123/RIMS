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
                SetInfoBoxText("Server up and running...");
                form.Invoke(new Action(() => { form.connectionLight.BackColor = Color.DarkGreen; }));

                ServerButtonIsEnabled(false);

                while (connected)
                {
                    TcpClient c = listener.AcceptTcpClient();
                    ClientHandler newClient = new ClientHandler(c, this, form, false, false, ((IPEndPoint)c.Client.RemoteEndPoint).Address.ToString());
                    clients.Add(newClient);

                    string questionText = "";
                    form.Invoke(new Action(() => { questionText = form.labelQuestion.Text; }));

                    Broadcast(questionText, true);
                    Connected();

                    Thread clientThread = new Thread(newClient.Run);
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {

                SetInfoBoxText("Något gick galet");
                ServerButtonIsEnabled(true);
            }
            finally
            {
                if (listener != null)
                {
                    listener.Stop();
                    ServerButtonIsEnabled(true);
                }
            }
        }

        public void Connected()
        {
            form.Invoke(new Action(() => { form.connectedBox.Items.Clear(); }));
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

                ListViewItem temp = (ListViewItem)form.Invoke(new Action(() => { form.connectedBox.Items.Add(ip); }));
                if(temp != null)
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

            
           
           
            form.Progress();
            
            form.Invoke(new Action(() => { form.labelClientReplyStatus.Text = $"Svarat: {clientsReplied} / {clientsConnected}"; }));
            form.Invoke(new Action(() => { form.connectedInfoBox.Text = clients.Count.ToString(); }));
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
            SetInfoBoxText($"Client {client.Alias} has left the building...");
            Connected();
        }

        public void SetInfoBoxText(string infoText)
        {
            if(form != null)
                form.Invoke(new Action(() => { form.infoBox.Text = infoText; }));
        }

        public void ServerButtonIsEnabled(bool isEnabled)
        {
            form.Invoke(new Action(() => { form.serverStartButton.Enabled = isEnabled; }));
        }
    }


}


