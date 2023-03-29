using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIOop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\nsb98\Documents\DotNet20DecBatch";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Directory is already exits");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Directory is created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\nsb98\Documents\DotNet20DecBatch\Sample.txt";
                if (File.Exists(path))
                {
                    MessageBox.Show("File is already exits");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File is created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\nsb98\Documents\DotNet20DecBatch\dept.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtDeptId.Text));
                bw.Write(txtDeptName.Text);
                bw.Write(txtLocation.Text);
                bw.Close();
                fs.Close();
                MessageBox.Show("Data added to file");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\nsb98\Documents\DotNet20DecBatch\dept.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtDeptId.Text = br.ReadInt32().ToString();
                txtDeptName.Text = br.ReadString();
                txtLocation.Text = br.ReadString();
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
