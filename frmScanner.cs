using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.InteropServices;


namespace SpexaAntiDefender
{
    public partial class frmScanner : Form
    {
        public frmScanner()
        {
            InitializeComponent();
        }

       

        public string GetMD5FromFile(string filenPath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filenPath))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();

                }
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrWhiteSpace(tbFilePath.Text))
            {
                string message = "You cannot leave the file path empty";
                string title = "Alert";
                MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Abort)
                {
                    this.Close();
                }
                else if (result == DialogResult.Retry)
                {
                    return;
                }
                else
                {
                    // Do something  
                }

            }

            else
            {

               
                frmScannerCirc frmScannerCirc = new frmScannerCirc();
                frmScannerCirc.Value = tbMD5.Text;
                frmScannerCirc.Show();
                
            }
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files|*.*";
            if(ofd.ShowDialog()==DialogResult.OK && ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbMD5.Text = GetMD5FromFile(ofd.FileName);
                string strfilename = ofd.FileName;
                tbFilePath.Text = strfilename;
                

            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFilePath.Text = String.Empty;
            tbMD5.Text = String.Empty;
            lblStatus.Text = String.Empty;
        }

       

     
    }
}
