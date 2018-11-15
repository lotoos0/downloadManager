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

namespace Download_Manager
{
    public partial class FormAddURL : Form
    {
        public FormAddURL()
        {
            
            InitializeComponent();
            if (CheckFileName.Checked = true)
                SaveAsLabel.Enabled = false;
            else
                SaveAsLabel.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveAsLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveAsBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckFileName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // DOWNLOAD TYPE COMBOBOX
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    
                    myStream.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //FormAddURL.Close = this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string URL = textBox1.Text;
            testBox.Text = URL + '\n';

            string dtSelected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            testBox.Text = dtSelected;

            var buttons = this.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

            if(buttons == RadioBT1)
                MessageBox.Show("1");
            else if(buttons == RadioBT2)
                MessageBox.Show("2");
            else
                MessageBox.Show("3");
        }   
    }
}
