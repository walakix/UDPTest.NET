using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Data.Common;
using System.Threading;


namespace UDPTest.NET
{
    public partial class Form1 : Form
    {
        Thread thdUDPServer;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            UDPServerStart();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            UDPServerStop();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            UDPSend("-");
        }


        public void UDPServerThread()
        {
            UdpClient udpClient = new UdpClient((int)numServerPort.Value);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                WriteLog(RemoteIpEndPoint.Address.ToString()
                                        + ":" + returnData.ToString());
            }
            //udpClient.Close();
        }

        private void WriteLog(string msg)
        {
            lbLog.Invoke((MethodInvoker)(() => lbLog.Items.Add(msg)));
        }

        private void UDPServerStart()
        {
            thdUDPServer = new Thread(new ThreadStart(UDPServerThread));
            thdUDPServer.Start();
            btnStart.Enabled = false; 
            numServerPort.Enabled = false;
            btnStop.Enabled=true;
        }

        private void UDPServerStop()
        {
            thdUDPServer.Abort();
            thdUDPServer=null;
            btnStart.Enabled = true;
            numServerPort.Enabled = true;
            btnStop.Enabled = false;
        }

        private void UDPSend(string msg)
        {
            UdpClient sender1 = new UdpClient();
            sender1.Send(Encoding.UTF8.GetBytes(tbMessage.Text), 3, tbDestIP.Text, (int)numDestPort.Value);
            sender1.Close();
        }
    }
}
