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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double final, inicial, cont;
            inicial = Double.Parse(textBox1.Text);
            final = Double.Parse(textBox2.Text);
            do
            {

                if (inicial < 0 || inicial > final)
                {
                    MessageBox.Show(" A distancia inicial nn pode ser negativa e nem maior q a final ");

                }
                else
                {
                    cont = (final - inicial) * 0.85;
                    textBox3.Text = cont.ToString();

                }
            } while (inicial < 0 || inicial > final);
        }
    }

}
