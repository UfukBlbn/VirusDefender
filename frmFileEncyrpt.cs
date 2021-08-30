using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace SpexaAntiDefender
{
    public partial class frmFileEncyrpt : Form
    {
        byte[] abc;
        byte[,] table;

        public frmFileEncyrpt()
        {
            InitializeComponent();
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK)
            {
                tPath.Text = od.FileName;
            }
        }

        private void rbEncyrpt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEncyrpt.Checked)
            {
                rbDecyrpt.Checked = false;
            }
        }

        private void rbDecyrpt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDecyrpt.Checked)
            {

                rbEncyrpt.Checked = false;
            }
        }

        DataTable area = new DataTable();

        private void frmFileEncyrpt_Load(object sender, EventArgs e)
        {
            area.Columns.Add("File Name", typeof(string));
            area.Columns.Add("Password", typeof(string));

            dataLister.DataSource = table;

            rbEncyrpt.Checked = true;

            abc = new byte[256];
            for (int i = 0; i < 256; i++)
                abc[i] = Convert.ToByte(i);

            table = new byte[256, 256];
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < 256; j++)
                {
                    table[i, j] = abc[(i + j) % 256];
                }

           

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (!File.Exists(tPath.Text))
            {
                MessageBox.Show("File does not exist !");
                return;

            }

            if (String.IsNullOrEmpty(tPassword.Text))
            {
                MessageBox.Show("Password is empty. Please enter the password");
                return;
            }

            try
            {
             

                byte[] fileContent = File.ReadAllBytes(tPath.Text);
                byte[] passwordTmp = Encoding.ASCII.GetBytes(tPassword.Text);
                byte[] keys = new byte[fileContent.Length];
                for (int i = 0; i < fileContent.Length; i++)
                    keys[i] = passwordTmp[i % passwordTmp.Length];
                
                
                //Encyrpt
                byte[] result = new byte[fileContent.Length];

                if (rbEncyrpt.Checked)
                {


                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;

                            }
                        result[i] = table[keyIndex, valueIndex];


                    }


                }
                else
                {
                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;

                        for (int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;

                            }
                        for (int j = 0; j < 256; j++)
                            if (table[keyIndex, j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        result[i] = abc[valueIndex];
                    }
                }
                String fileExt = Path.GetExtension(tPath.Text);
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "Files (*" + fileExt + ")| *" + fileExt;
                if(sd.ShowDialog()== DialogResult.OK)
                {
                    File.WriteAllBytes(sd.FileName, result);
                }
            }
            catch
            {
                MessageBox.Show("File is in use. Close the program is using this field and try again");
                return;
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            area.Rows.Add(tPath.Text, tPassword.Text);
            dataLister.DataSource = area;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataLister.SelectedRows)
                if (!row.IsNewRow) dataLister.Rows.Remove(row);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 1 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }
    }
  }

