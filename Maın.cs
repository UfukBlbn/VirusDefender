using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpexaAntiDefender
{
    public partial class Maın : Form
    {
        public Maın()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += +2;
            if (panel2.Width >= 700)
            {
                timer1.Stop();
                Form1 fPass = new Form1();
                fPass.Show();
                this.Hide();
            }
        }
    }
}
