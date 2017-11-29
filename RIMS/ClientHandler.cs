using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RIMS
{
    class ClientHandler
    {
        public TcpClient tcpclient;
        private Server myServer;
        Form1 form;
        public ClientHandler(TcpClient c, Server server, Form1 form)
        {
            tcpclient = c;
            this.myServer = server;
            this.form = form;
        }

        public void Run()
        {
            try
            {
                string message = "";
                while (!message.Equals("quit"))
                {
                    NetworkStream n = tcpclient.GetStream();
                    message = new BinaryReader(n).ReadString();
                    myServer.Broadcast(this, message);
                    form.Info(message);
                }

                myServer.DisconnectClient(this);
                tcpclient.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                myServer.DisconnectClient(this);
                tcpclient.Close();

            }
        }

    }
}
