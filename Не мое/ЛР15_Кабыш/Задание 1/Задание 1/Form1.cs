using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        int flag = 0, number = -1, pos = 0, kol = -1;
        string laststr = "", h ="";

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            richTextBox1.Text = fileText;
        }

        int[] positions = new int[10];
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                string pattern = @"\b[а-яА-Я]{1,}?$";
                flag = 1;
                Regex regex = new Regex(pattern);
                    foreach (Match match in regex.Matches(richTextBox1.Text))
                    {
                        pos = richTextBox1.Text.IndexOf(match.Value);
                        laststr = match.Value;
                        richTextBox1.Select(pos, match.Value.Length);
                        richTextBox1.SelectionColor = Color.Red; //меняем цвет выделенному слову      
                        pattern = @"(а)";
                        regex = new Regex(pattern);
                        foreach (Match n in regex.Matches(laststr))
                        {
                            pos = richTextBox1.Text.IndexOf(n.Value, pos);
                            positions[++number] = pos;
                            pos++;                            
                        }
                }
            } else
             {
                kol++; 
                richTextBox1.Select(positions[kol], 1);
                richTextBox1.SelectionColor = Color.Green;
                if (number == kol)
                {
                    string message = "Все буквы выделены. Букв 'а' в последнем слове - " + number;
                    MessageBox.Show(message);
                    number = 0; flag = 0; kol = 0;
                    richTextBox1.Select(0, richTextBox1.Text.Length);
                    richTextBox1.SelectionColor = Color.Black;
                }
            }      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
