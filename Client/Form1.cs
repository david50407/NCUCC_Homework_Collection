using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibrary;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IPEndPoint hostEP = new IPEndPoint(
                    IPAddress.Parse(this.dataPanel1.tbServerIP.Text),
                    int.Parse(this.dataPanel1.tbServerPort.Text)
                    );
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                socket.Connect(hostEP);
                byte[] byteSend = new byte[1024];

                // Serialize
                BinaryFormatter bf = new BinaryFormatter();
                MemoryStream stream = new MemoryStream();
                class_person person = new class_person();
                person.id = this.dataPanel1.tbDataID.Text;
                person.name = this.dataPanel1.tbDataName.Text;
                bf.Serialize(stream, person);

                byteSend = stream.ToArray();
                socket.SendTo(byteSend, 0, hostEP);
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
