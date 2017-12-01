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
        public static string IP;
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
                    form.Invoke(new Action(() => { questionText = form.textBoxQuestion.Text; }));

                    Broadcast(questionText, true);
                    //Connected();

                    Thread clientThread = new Thread(newClient.Run);
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                SetInfoBoxText("Servern kunde ej startas");
                ServerButtonIsEnabled(true);
            }
            finally
            {
                if (listener != null)
                {
                    listener.Stop();
                    form.Invoke(new Action(() => { form.connectionLight.BackColor = Color.Red; }));                   
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
                if (string.IsNullOrEmpty(client.Alias))
                {
                    client.Alias = "Håkan";
                }
                

                ListViewItem temp = new ListViewItem();
                form.Invoke(new Action(() => { temp = form.connectedBox.Items.Add(ip); }));

                form.Invoke(new Action(() => { temp.Text = client.Alias; }));

                if (client.Yes)
                {
                    SetColor(Color.Green, temp);
                    clientsReplied++;
                }

                if (client.No)
                {
                    SetColor(Color.Red, temp);
                    clientsReplied++;
                }
            }
            form.Invoke(new Action(() => { form.Progress(); }));           
            form.Invoke(new Action(() => { form.labelClientReplyStatus.Text = $"Svarat: {clientsReplied} / {clientsConnected}"; }));
            form.Invoke(new Action(() => { form.labelClientReplyStatus.BackColor = Color.GhostWhite; }));

            if (clientsReplied==clientsConnected)
            {
                form.Invoke(new Action(() => { form.labelClientReplyStatus.BackColor=Color.Green; }));
                form.Invoke(new Action(() => { form.labelClientReplyStatus.Text = $"Alla har svarat: {clientsReplied} / {clientsConnected}"; }));
            }
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
                w.Flush(); // redundant
                //Connected();
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
                form.Invoke(new Action(() => { form.infoBox.Text = infoText; }));
        }
        
        public void ServerButtonIsEnabled(bool isEnabled)
        {
            form.Invoke(new Action(() => { form.serverStartButton.Enabled = isEnabled; }));
        }

        public void SetColor(Color color, ListViewItem lv)
        {
            form.Invoke(new Action(() => { lv.BackColor = color; }));
        }
    }
}


