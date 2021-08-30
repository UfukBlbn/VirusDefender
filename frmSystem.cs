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

namespace SpexaAntiDefender
{
    public partial class frmSystem : Form
    {
        PerformanceCounter perform = new PerformanceCounter("Processor", "% Processor Time", "_Total");

        PerformanceCounter perform2 = new PerformanceCounter("Processor", "% Processor Time", "_Total");

        public frmSystem()
        {
            InitializeComponent();

        }

        private void frmSystem_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = perform.NextValue();
            float dram = perform2.NextValue();
            circularProgressBar1.Value = (int)fcpu;
            circularProgressBar1.Text = string.Format("{0:0}%", fcpu);

            circularProgressBar2.Value = (int)dram;
            circularProgressBar2.Text = string.Format("{0:0}%", dram);

        }

        
    }
}
