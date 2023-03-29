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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                SaveFileDialog saveFileDialog= new SaveFileDialog();
                saveFileDialog.Filter = "(*.txt notepad file)|*.txt|(*.docx document)|*.docx|(*.* All files)|*.*";
                saveFileDialog.DefaultExt = "(*.txt notepad file)|*.txt|(*.docx document)|*.docx|(*.* All files)|*.*";
                saveFileDialog.FileName = "myFile";
                DialogResult reresult=saveFileDialog.ShowDialog();
                if(DialogResult==DialogResult.OK)
                {
                    StreamWriter sw= new StreamWriter(saveFileDialog.FileName);
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog openFileDialog= new OpenFileDialog();
                openFileDialog.Filter = "(*.txt notepad file)|*.txt|(*.docx document)|*.docx|(*.* All files)|*.*";
                openFileDialog.DefaultExt = "(*.txt notepad file)|*.txt|(*.docx document)|*.docx|(*.* All files)|*.*";
            DialogResult result=openFileDialog.ShowDialog();    
                if(result==DialogResult.OK)
                {
                    StreamReader streamReader= new StreamReader(openFileDialog.FileName);
                    richTextBox1= new RichTextBox();
                    streamReader.Close();
                }
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            
        }
    }
}
