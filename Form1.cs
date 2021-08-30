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

namespace SpexaAntiDefender
{
    public partial class Form1 : Form
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


        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNavg.Height = btnMenu.Height;
            pnlNavg.Top = btnMenu.Top;
            pnlNavg.Left = btnMenu.Left;
           
            lblTitle.Text = "General Status";
            this.PnlFormLoader.Controls.Clear();
            frmMenu frmMenu_Vrb = new frmMenu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmMenu_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmMenu_Vrb);
            frmMenu_Vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnlNavg.Height = btnMenu.Height;
            pnlNavg.Top = btnMenu.Top;
            pnlNavg.Left = btnMenu.Left;
            btnMenu.BackColor = Color.FromArgb(46, 51, 73);
            lblTitle.Text = "General Status";
            this.PnlFormLoader.Controls.Clear();
            frmMenu frmMenu_Vrb = new frmMenu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmMenu_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmMenu_Vrb);
            frmMenu_Vrb.Show();



        }

        private void btnScan_Click(object sender, EventArgs e)
        {

            pnlNavg.Height = btnScan.Height;
            pnlNavg.Top = btnScan.Top;
            pnlNavg.Left = btnScan.Left;
            btnScan.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Scanner";
            this.PnlFormLoader.Controls.Clear();
            frmScanner frmScanner_Vrb = new frmScanner() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmScanner_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmScanner_Vrb);
            frmScanner_Vrb.Show();

        }

        private void btnSystem_Click(object sender, EventArgs e)
        {

            pnlNavg.Height = btnSystem.Height;
            pnlNavg.Top = btnSystem.Top;
            pnlNavg.Left = btnSystem.Left;
            btnSystem.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "System";
            this.PnlFormLoader.Controls.Clear();
            frmSystem frmSystem_Vrb = new frmSystem() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSystem_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmSystem_Vrb);
            frmSystem_Vrb.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            pnlNavg.Height = button1.Height;
            pnlNavg.Top = button1.Top;
            pnlNavg.Left = button1.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "File Encyrption";
            this.PnlFormLoader.Controls.Clear();
            frmFileEncyrpt frmFileEncyrpt_Vrb = new frmFileEncyrpt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFileEncyrpt_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmFileEncyrpt_Vrb);
            frmFileEncyrpt_Vrb.Show();

        }

        private void btnImgEncy_Click(object sender, EventArgs e)
        {

            pnlNavg.Height = btnImgEncy.Height;
            pnlNavg.Top = btnImgEncy.Top;
            pnlNavg.Left = btnImgEncy.Left;
            btnImgEncy.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Network Scanner";
            this.PnlFormLoader.Controls.Clear();
            frmNetworkScan frmNetworkScan_Vrb = new frmNetworkScan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmNetworkScan_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmNetworkScan_Vrb);
            frmNetworkScan_Vrb.Show();

        }

        

        private void btnMenu_Leave(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.FromArgb(24, 30, 65);
        }

        private void btnScan_Leave(object sender, EventArgs e)
        {
            btnScan.BackColor = Color.FromArgb(24, 30, 65);
        }

        private void btnSystem_Leave(object sender, EventArgs e)
        {
            btnSystem.BackColor = Color.FromArgb(24, 30, 65);
        }

        

        private void btnImgEncy_Leave(object sender, EventArgs e)
        {
            btnImgEncy.BackColor = Color.FromArgb(24, 30, 65);
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(24, 30, 65);
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlNavg.Height = button3.Height;
            pnlNavg.Top = button3.Top;
            pnlNavg.Left = button3.Left;
            button3.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Virtual Private Network";
            this.PnlFormLoader.Controls.Clear();
            frmVpn frmVpn_Vrb = new frmVpn() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmVpn_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmVpn_Vrb);
            frmVpn_Vrb.Show();

        }

        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(24, 30, 65);
        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
