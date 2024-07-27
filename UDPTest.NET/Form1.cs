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
        //Thread thdUDPServer;
        bool thRun=false;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (thRun) { UDPServerStop(); }
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
            UDPSend(tbMessage.Text);
        }


        public void UDPServerThread()
        {
            UdpClient udpClient = new UdpClient((int)numServerPort.Value);
            while (thRun)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);
                if (returnData=="QUIT_EndThread")
                {
                    
                } 
                else
                {
                    WriteLog(RemoteIpEndPoint.Address.ToString()
                                            + ": " + returnData.ToString());
                }
            }
            udpClient.Close();
            udpClient.Dispose();
            //udpClient = null;
        }

        private void WriteLog(string msg)
        {
            lbLog.Invoke((MethodInvoker)(() => lbLog.Items.Add(msg)));
            lbLog.Invoke((MethodInvoker)(() => lbLog.SelectedIndex= lbLog.Items.Count-1));
            lbLog.Invoke((MethodInvoker)(() => lbLog.ClearSelected()));
        }

        private void UDPServerStart()
        {
            Thread thdUDPServer = new Thread(new ThreadStart(UDPServerThread));
            thRun = true;
            thdUDPServer.Start();
            
            btnStart.Enabled = false; 
            numServerPort.Enabled = false;
            btnStop.Enabled=true;
        }

        private void UDPServerStop()
        {
            thRun = false;
            //thdUDPServer.Abort();
            UdpClient sender2 = new UdpClient();
            string endMsg = "QUIT_EndThread";
            sender2.Send(Encoding.UTF8.GetBytes(endMsg), endMsg.Length, "127.0.0.1", (int)numServerPort.Value);
            sender2.Close();

            //UDPSend("QUIT_EndThread");

            btnStart.Enabled = true;
            numServerPort.Enabled = true;
            btnStop.Enabled = false;
        }

        private void UDPSend(string msg)
        {
            UdpClient sender1 = new UdpClient();
            sender1.Send(Encoding.UTF8.GetBytes(msg), msg.Length, tbDestIP.Text, (int)numDestPort.Value);
            sender1.Close();
        }
    }
}
