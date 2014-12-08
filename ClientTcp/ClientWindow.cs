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

namespace ClientTcp
{
    public partial class ClientWindow : Form
    {
        TcpClient ClientTcp;
        IPAddress ServerIP;
        int ServerPort;
        const string LF = "\r\n";

        public ClientWindow()
        {
            InitializeComponent();
        }

        private void btn_connection_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                try
                {
                    IPEndPoint serverEndpoint = new IPEndPoint(ServerIP, ServerPort);
                    ClientTcp = new TcpClient();
                    rtb_console.AppendText("Connecting " + ServerIP.ToString() + ":" + ServerPort.ToString() + "..." + LF);
                    ClientTcp.Connect(serverEndpoint);
                    rtb_console.AppendText("Connected." + LF);

                    btn_connect.Enabled = false;
                    btn_deconnect.Enabled = true;
                    txt_sendmessage.Enabled = true;
                }
                catch (SocketException)
                {
                    rtb_console.AppendText("Server is unreacheable. Check server configuration." + LF);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInputs()
        {
            bool validationToReturn = true;

            bool validateport = int.TryParse(txt_serverport.Text, out ServerPort);
            bool validateIP = IPAddress.TryParse(txt_serverip.Text, out ServerIP);

            if (!validateport)
            {
                MessageBox.Show("Port must be a number between 1024 and 65536.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validationToReturn = false;
            }
            else
            {
                if (ServerPort < 1024 || ServerPort > 65536)
                {
                    MessageBox.Show("Port must be a number between 1024 and 65536.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationToReturn = false;
                }
            }

            if (!validateIP)
            {
                MessageBox.Show("Enter a valid IP address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validationToReturn = false;
            }

            return validationToReturn;
        }

        private void btn_deconnect_Click(object sender, EventArgs e)
        {
            ClientTcp.GetStream().Close();
            ClientTcp.Close();
            rtb_console.AppendText("Deconnected." + LF);

            btn_connect.Enabled = true;
            btn_deconnect.Enabled = false;
            txt_sendmessage.Enabled = false;
        }

        private void txt_sendmessage_Click(object sender, EventArgs e)
        {
            if (ClientTcp.Connected)
            {
                try
                {
                    NetworkStream clientStream = ClientTcp.GetStream();
                    if (clientStream.CanWrite)
                    {
                        byte[] encodedData = Encoding.ASCII.GetBytes(rtb_sendmessage.Text);
                        clientStream.Write(encodedData, 0, encodedData.Length);
                        rtb_console.AppendText(rtb_sendmessage.Text + LF);
                        rtb_sendmessage.Clear();
                        rtb_sendmessage.Focus();
                    }
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }
        }
    }
}
