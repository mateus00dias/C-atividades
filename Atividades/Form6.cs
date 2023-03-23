using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividades
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, delta;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b) && double.TryParse(textBox3.Text, out c))
            {
                delta = (b * b) - (4 * a * c);

                if (delta < 0)
                {
                    MessageBox.Show("A equação do segundo grau não possui raízes reais.");
                }
                else if (delta == 0)
                {

                    double raiz = -b / (2 * a);

                    textBox5.Text = raiz.ToString();
                }
                else
                {

                    double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    textBox5.Text = raiz1.ToString();
                    textBox6.Text = raiz2.ToString();
                }
            }
            else
            {
                MessageBox.Show("Algum dos valores digitados não é numérico.");
            }

        }
    }

}