using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividades
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3;

            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            n3 = double.Parse(textBox3.Text);

            double maior = n1;

            if (n2 > maior)
            {

                maior = n2;
            }
            if (n3 > maior)
            {
                maior = n3;
            }

            textBox4.Text = maior.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
}
