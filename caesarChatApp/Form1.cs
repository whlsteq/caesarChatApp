using System.Net;
using System.Net.Sockets;
namespace caesarChatApp
{
    public partial class Form1 : Form
    {
        String myIP;
        String myPort;
        Socket socket;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //set up socket
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //myIP
            myIP = GetLocalIP();
            myPort=txt_port.Text;//because i am used 1 port
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
            epLocal = new IPEndPoint(IPAddress.Parse(myIP), Convert.ToInt32(myPort));
            socket.Bind(epLocal);
            //connecting to remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(txt_ip.Text), Convert.ToInt32(txt_port.Text));
            socket.Connect(epRemote);
            //listening the specific port
            buffer = new byte[9999];
            socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[9999];
                receivedData = (byte[])aResult.AsyncState;
                //Converting byte[] to string
                System.Text.ASCIIEncoding aEncoding = new System.Text.ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);
                //Adding this message into MessageBox
                rtxt_dataMessage.Text = $"{txt_nickname} :" + receivedMessage;

                buffer = new byte[9999];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()+"     ----------------------"      +ex.StackTrace.ToString());
            }
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            //Convert string message to byte[]
            System.Text.ASCIIEncoding aEncoding = new System.Text.ASCIIEncoding();
            byte[] sendingMessage = new byte[9999];
            sendingMessage = aEncoding.GetBytes(txt_message.Text);
            //Sending the Encoded message
            socket.Send(sendingMessage);
            //adding to the MessageBox
            rtxt_dataMessage.Text = $"{txt_nickname} :" + sendingMessage;
        }
    }
}