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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double altura, bas, area; 

            altura = double.Parse(textBox3.Text);
            bas = double.Parse(textBox1.Text);

            area = bas * altura;

            textBox2.Text = area.ToString();
        }
    }
}
