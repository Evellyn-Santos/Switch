using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Switch
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idade;
            idade = Convert.ToInt32(listBox1.Text);
           
            switch (idade)
            {
                case 1:
                    MessageBox.Show("Acabou o mesversario! É seu primeiro ano de vida!!");
                    break;
                case 15:
                    MessageBox.Show("Parabéns, você debutou!!");
                    break;
                case 18:
                    MessageBox.Show("Cuidado, você pode ser preso!!");
                    break;
                case 21:
                    MessageBox.Show("Virou adulto de verdade!!");
                    break;
                case 65:
                    MessageBox.Show("Você pode descançar agora");
                    break;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("1");
            listBox1.Items.Add("15");
            listBox1.Items.Add("18");
            listBox1.Items.Add("21");
            listBox1.Items.Add("65");
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
