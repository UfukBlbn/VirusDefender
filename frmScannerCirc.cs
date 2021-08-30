using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.IO;


namespace SpexaAntiDefender
{
    public partial class frmScannerCirc : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
          (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse
          );

        public frmScannerCirc(string value)
        {

            InitializeComponent();
            // lblValue.Text = value;
            this.Value = value;
        }

        public frmScannerCirc()
        {

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            circularProgressBar1.Value = 0;
            
            
        }
        public string Value { get; set; }

        private void frmScannerCirc_Load(object sender, EventArgs e)
        {
            lblValue.Text=Value;
            lblValue.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var md5signatures = File.ReadAllLines("MD5Base.txt");
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString() + "%";

            if (circularProgressBar1.Value==100)
            {
                timer1.Enabled = false;

                if(md5signatures.Contains(lblValue.Text))

                {
                    lblstatu.Text = "Virus Detected";
                    lblstatu.ForeColor = Color.Red;
                }

                else
                {
                    lblstatu.Text = "File is Clean";
                    lblstatu.ForeColor = Color.Green;
                }

                
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
