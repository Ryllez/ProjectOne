using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Double.Parse(textBox1.Text) + Double.Parse(textBox2.Text));
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Double.Parse(textBox1.Text) * Double.Parse(textBox2.Text));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Double.Parse(textBox1.Text) - Double.Parse(textBox2.Text));
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Double.Parse(textBox1.Text) / Double.Parse(textBox2.Text));
        }
    }
}
