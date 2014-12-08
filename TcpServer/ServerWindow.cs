using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace TcpServer
{
    public partial class ServerWindow : Form
    {
        private TcpListener ServerTcp;
        private int port;
        private const string LF = "\r\n";

        public ServerWindow()
        {
            InitializeComponent();
        }

        private async void btn_startserver_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    ServerTcp = new TcpListener(IPAddress.Any, port);

                    ServerTcp.Start(10);
                    rtb_console.AppendText("Server started." + LF);
                    rtb_console.AppendText("Waiting for client..." + LF);

                    btn_startserver.Enabled = false;
                    btn_stopserver.Enabled = true;

                    while (true)
                    {
                        TcpClient client = await ServerTcp.AcceptTcpClientAsync();
                        IPEndPoint socketClientEndpoint = client.Client.RemoteEndPoint as IPEndPoint;
                        rtb_console.AppendText("Client " + socketClientEndpoint.Address + ":" + socketClientEndpoint.Port + " is connected." + LF);

                        Communicate(client, socketClientEndpoint);
                       
                    }
                    
                }

            }
            catch (SocketException)
            {
                rtb_console.AppendText("Port is already binded to another service. Choose an another port." + LF);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_stopserver_Click(object sender, EventArgs e)
        {
            ServerTcp.Stop();
            rtb_console.AppendText("Server stopped." + LF);
            btn_startserver.Enabled = true;
            btn_stopserver.Enabled = false;
        }

        private bool ValidateInput()
        {
            bool validationToReturn = true;

            bool convertPort = int.TryParse(txt_port.Text, out port);

            if (convertPort)
            {
                if (port < 1024 || port > 65536)
                {
                    MessageBox.Show("Please choose a port between 1024 and 65536", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationToReturn = false;
                }
            }
            else
            {
                MessageBox.Show("Please choose a port between 1024 and 65536", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validationToReturn = false;
            }

            return validationToReturn;
        }

        /// <summary>
        /// Check the connection status of the client - Server side - in order to close it.
        /// </summary>
        /// <param name="client">The TCPClient socket.</param>
        /// <returns>true for active, false for closed.</returns>
        private bool CheckSocketState(TcpClient client)
        {
            bool status = true;
            try
            {
                if (client.Client.Poll(0, SelectMode.SelectRead))
                {
                    byte[] buff = new byte[1];
                    if (client.Client.Receive(buff, SocketFlags.Peek) == 0)
                    {
                        // Client disconnected
                        status = false;
                    }
                }
            }
            catch (Exception)
            {       
                throw;
            }
            

            return status;
        }

        private async void Communicate(TcpClient client, IPEndPoint socketClientEndpoint)
        {
            while (CheckSocketState(client))
            {

                NetworkStream streamClient = client.GetStream();
                if (streamClient.CanRead)
                {
                    List<byte> dataToReceive = new List<byte>();
                    byte[] buffer = new byte[2048];
                    int bytesRead = 0;

                    //Synchron Mode
                    //bytesRead = streamClient.Read(buffer, 0, buffer.Length);

                    bytesRead = await streamClient.ReadAsync(buffer, 0, buffer.Length);
                    dataToReceive.AddRange(buffer);


                    if (dataToReceive != null && dataToReceive.Count > 0)
                    {
                        byte[] bytesData = dataToReceive.ToArray();
                        String message = Encoding.ASCII.GetString(bytesData);
                        rtb_console.AppendText(socketClientEndpoint.Address + ":" + socketClientEndpoint.Port + " said : ");
                        rtb_console.AppendText(message);
                        rtb_console.AppendText(LF);

                    }

                }

            }

            rtb_console.AppendText("Client " + socketClientEndpoint.Address + ":" + socketClientEndpoint.Port + "is deconnected." + LF);
        }

    }
}
