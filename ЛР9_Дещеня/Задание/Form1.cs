using System;
using System.Windows.Forms;

namespace Задание
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct facult {
            public string name;
            public string decan;
            public string telefon;
            public string adress;

            public facult(string name, string decan, string telefon, string adress)
            {
                this.name = name;
                this.decan = decan;
                this.telefon = telefon;
                this.adress = adress;
            }

            public string[] ToParam()
            {
                string[] arr = { name, decan, telefon, adress};
                return arr;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            facult NewFacult = new facult(textBox1.Text, textBox6.Text, textBox7.Text, textBox8.Text);
            dataGridView1.Rows.Add(NewFacult.ToParam());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox5.Text;

            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                string rowname = i.Cells[0].Value?.ToString() ?? "";

                if (rowname == name)
                {
                    label7.Text = $"Кафедра Дисциплины: {i.Cells[1].Value}.";
                    label8.Text = $"ФИО преподавателя ведущего лекции: {i.Cells[2].Value}";
                    label9.Text = $"ФИО преподавателя ведущего лабораторные работы: {i.Cells[3].Value}";
                    return;
                }
            }

            label7.Text = $"Не удалось найти дисциплину под названием: {name}";
        }

 
    }
}
