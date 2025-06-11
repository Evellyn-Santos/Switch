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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                n = Convert.ToInt32(textBox1.Text);

                switch (n)
                {
                    case 1:
                        label2.Text = "Você digitou o número 1";
                        break;

                    case 2:
                        label2.Text = "Você digitou o número 2";
                        break;

                    case 3:
                        label2.Text = "Você digitou o número 3";
                        break;

                    case 4:
                        label2.Text = "Você digitou o número 4";
                        break;

                    case 5:
                        label2.Text = "Você digitou o número 5";
                        break;

                    case 6:
                        label2.Text = "Você digitou o número 6";
                        break;

                    case 7:
                        label2.Text = "Você digitou o número 7";
                        break;

                    case 8:
                        label2.Text = "Você digitou o número 8";
                        break;

                    case 9:
                        label2.Text = "Você digitou o número 9";
                        break;

                    case 10:
                        label2.Text = "Você digitou o número 10";
                        break;

                    default:
                        label2.Text = "Você digitou um número inválido";
                        break;
                }

            } catch (Exception) {
                MessageBox.Show("Digite um número válido", MessageBoxIcon.Error.ToString());
                    }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
