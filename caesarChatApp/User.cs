using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caesarChatApp
{
    public partial class User : Form
    {
        String myIP;
        Socket socket;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        public User()
        {
            InitializeComponent();
        }
        private void User_Load(object sender, EventArgs e)
        {
            //set up socket
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //myIP
            myIP = GetLocalIP();
            //get user IP
            txt_ip.Text = GetLocalIP();//exp:144.106.45.44 but primal local ip address
        }
        private string GetLocalIP()
        {
            IPHostEntry ipAddress;
            ipAddress = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in ipAddress.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)

                {
                    return ip.ToString();

                }

            }
            return "127.0.0.1";
        }
        private void btn_connect_Click(object sender, EventArgs e)
        {
            //binding Socket
            epLocal = new IPEndPoint(IPAddress.Parse(myIP), Convert.ToInt32(txt_port.Text));
        }

        private void btn_send_Click(object sender, EventArgs e)
        {

        }


    }
}
