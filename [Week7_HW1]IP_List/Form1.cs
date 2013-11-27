using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Week7_HW1_IP_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            refreshIPList();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshIPList();
        }

        private void refreshIPList()
        {
            this.listBoxIPs.Items.Clear();
            NetworkInterface[] networkCards = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface networkCard in networkCards)
            {
                IPInterfaceProperties IPinfo = networkCard.GetIPProperties();
                UnicastIPAddressInformationCollection IPAddressInfos = IPinfo.UnicastAddresses;
                foreach (UnicastIPAddressInformation IPAddressInfo in IPAddressInfos)
                    if (IPAddressInfo.Address.AddressFamily == AddressFamily.InterNetwork)
                        this.listBoxIPs.Items.Add((IPAddressInfo.Address.ToString()));
            }
        }
    }
}
