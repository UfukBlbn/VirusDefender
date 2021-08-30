using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace SpexaAntiDefender
{
    public partial class frmVpn : Form
    {
        public frmVpn()
        {
            InitializeComponent();
        }
        private static string FolderPath => string.Concat(Directory.GetCurrentDirectory(),
            "\\VPN");

        private void frmVpn_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnectVpn_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(FolderPath))
                Directory.CreateDirectory(FolderPath);

            var sb = new StringBuilder();
            sb.AppendLine("[VPN]");
            sb.AppendLine("MEDIA=rastapi");
            sb.AppendLine("Port=VPN2-0");
            sb.AppendLine("Device=WAN Miniport (IKEv2)");
            sb.AppendLine("DEVICE=vpn");
            sb.AppendLine("PhoneNumber=" + txtHost.Text);

            File.WriteAllText(FolderPath + "\\VpnConnection.pbk", sb.ToString());

            sb = new StringBuilder();
            sb.AppendLine("rasdial \"VPN\" " + txtUsrname.Text + " " + txtPassword.Text + " /phonebook:\"" + FolderPath +
                          "\\VpnConnection.pbk\"");

            File.WriteAllText(FolderPath + "\\VpnConnection.bat", sb.ToString());

            var newProcess = new Process
            {
                StartInfo =
                {
                    FileName = FolderPath + "\\VpnConnection.bat",
                    WindowStyle = ProcessWindowStyle.Normal
                }
            };

            newProcess.Start();
            newProcess.WaitForExit();
            btnConnectVpn.Enabled = false;
            btnDısConnectVpn.Enabled = true;
        }

        private void btnDısConnectVpn_Click(object sender, EventArgs e)
        {

           
                File.WriteAllText(FolderPath + "\\VpnDisconnect.bat", "rasdial /d");

                var newProcess = new Process
                {
                    StartInfo =
                {
                    FileName = FolderPath + "\\VpnDisconnect.bat",
                    WindowStyle = ProcessWindowStyle.Normal
                }
                };

                newProcess.Start();
                newProcess.WaitForExit();
                btnConnectVpn.Enabled = true;
                btnDısConnectVpn.Enabled = false;
            }
        }
    
}
