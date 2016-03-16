using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(byte[] data);
        delegate void GetTextCallback();

        protected bool opened = false;
        private Thread startThread;
        private Socket socket;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (opened)
            {
                startThread.Abort();
                this.button1.Text = "Start Listen Data";
                opened = false;
            }
            else
            {
                startThread = new Thread(new ParameterizedThreadStart(start));
                startThread.Start();
                this.button1.Text = "Stop Listen Data";
                opened = true;
            }
        }

        private void start(object TransMgs)
        {
            IPEndPoint hostEP = new IPEndPoint(
                IPAddress.Parse(this.dataPanel1.tbServerIP.Text), 
                int.Parse(this.dataPanel1.tbServerPort.Text)
                );
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(hostEP);

            while (true)
            {
                try
                {
                    byte[] byteRcv = new byte[1024];
                    socket.Receive(byteRcv);
                    SetText(byteRcv);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void SetText(byte[] data)
        {
            // De-Serialize
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream stream = new MemoryStream(data);
            class_person person = (class_person)bf.Deserialize(stream);

            if (this.dataPanel1.tbDataID.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { data });
            }
            else
            {
                this.dataPanel1.tbDataID.Text = person.id;
            }

            if (this.dataPanel1.tbDataName.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { data });
            }
            else
            {
                this.dataPanel1.tbDataName.Text = person.name;
            }
        }
    }
}
