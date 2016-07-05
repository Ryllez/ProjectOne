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
            switch (((Button)sender).Name)
            {
                case "addition":
                    {
                        result = firstValue + secondValue;
                        break;
                    }
                case "subtraction":
                    {
                        result = firstValue - secondValue;
                        break;
                    }
                case "multiplication":
                    {
                        result = firstValue * secondValue;
                        break;
                    }
                case "division":
                    {
                        result = firstValue / secondValue;
                        break;
                    }
                default:
                    throw new Exception("Неизвестная операция");
            }
            textBox3.Text = result.ToString();
        }
        
    }
}
