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
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;


namespace SpexaAntiDefender
{
    public partial class frmNetworkScan : Form
    {
        public frmNetworkScan()
        {
            InitializeComponent();
        }

        private void frmNetworkScan_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void btnScanner_Click(object sender, EventArgs e)
        {

                progressBar.Visible = true;
                string subnet = tbScanIP.Text;
                progressBar.Maximum = 254;
                progressBar.Value = 0;
                lvResult.Items.Clear();

                Task.Factory.StartNew(new Action(() =>
                {
                    for (int i = 2; i < 255; i++)
                    {
                        string ip = $"{subnet}.{i}";
                        Ping ping = new Ping();
                        PingReply reply = ping.Send(ip, 100);
                        if (reply.Status == IPStatus.Success)
                        {
                            progressBar.BeginInvoke(new Action(() =>
                            {
                                try
                                {
                                    IPHostEntry host = Dns.GetHostEntry(IPAddress.Parse(ip));
                                    lvResult.Items.Add(new ListViewItem(new String[] { ip, host.HostName, "Up" }));
                                }
                                catch
                                {
                                    
                                }
                                progressBar.Value += 1;
                                lblStatus.ForeColor = Color.Blue;
                                MessageBox.Show("Dangerous network connection has been detected","Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                lblStatus.Text = $"Scanning: {ip}";
                                if (progressBar.Value == 253)
                                    lblStatus.Text = "Finished";
                                    lblStatus.ForeColor = Color.Green;
                            }));
                        }
                        else
                        {
                            progressBar.BeginInvoke(new Action(() =>
                            {
                                progressBar.Value += 1;
                               
                                lblStatus.ForeColor = Color.DarkGray;
                                lblStatus.Text = $"Scanning: {ip}";
                                lvResult.Items.Add(new ListViewItem(new String[] { ip, "", "Down" }));
                                if (progressBar.Value == 253)
                                    lblStatus.Text = "Finished";
                                lblStatus.ForeColor = Color.Red;
                            }));
                        }
                    }
                }));
            
        }

        
    }
}
