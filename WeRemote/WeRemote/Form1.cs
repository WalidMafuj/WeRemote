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
            comboBox1.Items.Add("UP");
            comboBox1.Items.Add("U");

        }
        Object keyu ;
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtstatus.Invoke((MethodInvoker)delegate ()
            {
                
                if (comboBox1.Text == "U")
                {
                    keyu = Keys.U;
                }
                else if(comboBox1.Text == "UP")
                {
                    keyu = Keys.Up;
                }
                string msg1 = e.MessageString;//.Substring(0, 3)
                txtstatus.Text += msg1;// "\r\n"
                e.ReplyLine(String.Format("GET {0}", e.MessageString));
                try
                {
                    if (msg1 == rec_1.Text)
                    {
                        Keyboard.KeyPress((Keys)'A');
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
                }
                catch
                {
                    report.Text = "Settings Error !! Fill the form first.";
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
                
            }
        }

        private void Clr_Click(object sender, EventArgs e)
        {
            txtstatus.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void press_box2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
