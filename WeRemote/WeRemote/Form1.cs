using SimpleTCP;
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
using InputManager;

namespace WeRemote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtIP.Text = GetLocalIPAddress();
            Stop.Enabled = false;
        }
        SimpleTcpServer server;
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;//enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtstatus.Invoke((MethodInvoker)delegate ()
            {
                string msg1 = e.MessageString;
                txtstatus.Text += msg1;// "\r\n"
                e.ReplyLine(String.Format("GET {0}", e.MessageString));
                if(msg1 == rec_1.Text)
                {
                    Keyboard.KeyPress(Keys.Up);
                }
                else if (msg1 == rec_2.Text)
                {
                    Keyboard.KeyPress(Keys.Left);
                }
                else if (msg1 == rec_3.Text)
                {
                    Keyboard.KeyPress(Keys.Down);
                }
                else if (msg1 == rec_4.Text)
                {
                    Keyboard.KeyPress(Keys.Right);
                }
            });

        }

        private void txtstatus_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (!server.IsStarted)
            {
                report.Text = "Server started";
                //IPAddress ip = IPAddress.Parse(txtHost.Text);
                System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtIP.Text);

                //System.Net.IPAddress ip = new System.Net.IPAddress(long.Parse(txtIP.Text));
                try
                {
                    server.Start(ip, Convert.ToInt32(txtPort.Text));
                    Start.Enabled = false;
                    Stop.Enabled = true;
                }
                catch
                {
                    report.Text = "Port:" + txtPort.Text + " is busy. try with different port";
                    Start.Enabled = true;
                }
                
            }
            
                
            
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
                Start.Enabled = true;
                Stop.Enabled = false;
                report.Text = "Server ended by user";
                txtstatus.Clear();
            }
        }
    }
}
