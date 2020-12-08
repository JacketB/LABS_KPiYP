using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            TopMost = true;
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @"C:\Users\mtx\Desktop\ДИНАМИКИ.bat";
            proc.StartInfo.WorkingDirectory = @"C:\Users\mtx\Desktop";
            proc.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @"C:\Users\mtx\Desktop\Наушники.bat";
            proc.StartInfo.WorkingDirectory = @"C:\Users\mtx\Desktop";
            proc.Start();
        }
    }
}
