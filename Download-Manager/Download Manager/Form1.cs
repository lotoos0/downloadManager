using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Download_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        }

        // BUTTON ADD URL
        FormAddURL formURL = new FormAddURL();
        // BUTTON ADD URL

        private void button3_Click(object sender, EventArgs e)
        {

            formURL.Show();
        }

        private void addNewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formURL.Show();
        }

        private void polishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region ZMIANA JĘZYKA MENU NA PL
            polishToolStripMenuItem.Checked = true;
            englishToolStripMenuItem.Checked = false;
            menuStrip2.Visible = true;
            menuStrip1.Visible = false;

            // zmiana MENU DOLNEGO

            button3.Text = "Dodaj URL";
            button2.Text = "Wznów";
            button1.Text = "Zatrzymaj";
            button4.Text = "Usuń";
            button5.Text = "Opcje";


            #endregion
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            #region ZMIANA JĘZYKA MENU NA ANG
            polishToolStripMenuItem.Checked = false;
            englishToolStripMenuItem.Checked = true;
            menuStrip2.Visible = false;
            menuStrip1.Visible = true;

            // ZMIANA MENU DOLNEGO

            button3.Text = "Add URL";
            button2.Text = "Resume";
            button1.Text = "Stop";
            button4.Text = "Delete";
            button5.Text = "Options";
            #endregion
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
        }
    }
}
