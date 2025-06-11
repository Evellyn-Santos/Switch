using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Esconder o form principal
            Form2 OutroForm = new Form2();
            OutroForm.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void númerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Esconder o form principal
            Form3 OutroForm = new Form3();
            OutroForm.ShowDialog();
        }

        private void númerosAleatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Esconder o form principal
            Form4 OutroForm = new Form4();
            OutroForm.ShowDialog();
        }
    }
}
