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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mes;
            mes = textBox1.Text.ToLower();

            switch(mes)
            {
                case "janeiro":
                case "março":
                case "maio":
                case "julho":
                case "agosto":
                case "outubro":
                case "dezembro":
                    label2.Text = "Este mês tem 31 dias";
                    break;

                case "abril":
                case "junho":
                case "setembro":
                case "novembro":
                    label2.Text = "Este mês tem 30 dias";
                    break;

                case "fevereiro":
                    label2.Text = "Este mês tem 28 dias";
                    break;

                default:
                    label2.Text = "Digite um mês válido";
                    break;

            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
