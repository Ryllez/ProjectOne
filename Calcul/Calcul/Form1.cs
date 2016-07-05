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
            double firstValue = Double.Parse(textBox1.Text);
            double secondValue = Double.Parse(textBox2.Text);
            double result;
            ITwoArgumentsCalculator calc = TwoArgumentCalculatorFactory.CreateCalculator(((Button)sender).Name);
            result = calc.Calculate(firstValue, secondValue);
            textBox3.Text = result.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double firstValue = Double.Parse(textBox1.Text);
            double result;
            IOneArgumentCalculator calc = OneArgumentCalculatorFactory.CreateCalculator(((Button)sender).Name);
            result = calc.Calculate(firstValue);
            textBox3.Text = result.ToString();
        }
        
    }
}
