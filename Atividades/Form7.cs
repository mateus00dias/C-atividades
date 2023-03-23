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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double raio, area, pi = 3.14159;
            raio = double.Parse(textBox1.Text);
            area = (pi * (raio * raio));

            textBox2.Text = area.ToString();
            textBox3.Text = pi.ToString();
            textBox4.Text = raio.ToString();

        }
    }
}
