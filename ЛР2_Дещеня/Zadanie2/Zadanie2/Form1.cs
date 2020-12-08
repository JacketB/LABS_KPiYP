using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z, b;

            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            z = double.Parse(textBox3.Text);

            b = Math.Abs(x - y) * ((Math.Pow(Math.Sin(z), 2)) + Math.Tan(z));
            label4.Text = "Результат = " + Math.Round(b, 2);
        }
    }
}
