using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace RIMS
{
    public class ClientHandler
    {
        public TcpClient tcpclient;
        private Server myServer;
        Form1 form;
        public bool Yes = false;
        public bool No = false;
        public string Alias;
        public string Ip;
        public ClientHandler(TcpClient c, Server server, Form1 form, bool yes, bool no, string ip)
        {
            tcpclient = c;
            this.myServer = server;
            this.form = form;
            Yes = yes;
            No = no;
            Ip = ip;
        }

        public void Run()
        {
            try
            {
                while (Server.connected)
                {
                    NetworkStream n = tcpclient.GetStream();
                    string message = new BinaryReader(n).ReadString();

                    ClientMessage myMessage = JsonConvert.DeserializeObject<ClientMessage>(message);
                    if (!myMessage.StayConnected)
                        break;
                    Ip = myMessage.Ip;
                    Alias = myMessage.Alias;

                    Yes = false;
                    No = false;
                    if (myMessage.Answer == "true")
                        Yes = true;
                    if (myMessage.Answer == "false")
                        No = true;

                    myServer.Connected();
                }
            }
            catch (Exception ex)
            {
                myServer.SetInfoBoxText($"{Ip} kunde ej koppla upp sig... {ex.Message}");
            }
            finally
            {
                myServer.DisconnectClient(this);
                tcpclient.Close();
            }
        }

    }
}
