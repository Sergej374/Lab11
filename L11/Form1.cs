using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text += "Cегодня\n";
            DateTime thisDay = DateTime.Today;
            richTextBox1.Text += thisDay.ToString() + "\n";
            richTextBox1.Text += thisDay.ToString("d") + "\n";
            richTextBox1.Text += thisDay.ToString("D") + "\n";
            richTextBox1.Text += thisDay.ToString("g") + "\n";

            string currentTime = DateTime.Now.TimeOfDay.ToString();
            richTextBox1.Text += currentTime + '\n';
            var someTime = new DateTime();
            richTextBox1.Text += someTime.ToString() + '\n';
            richTextBox1.Text += DateTime.Now.ToString() + '\n';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime sDay = DateTime.Today;
            label2.Text = "День " + sDay.Day;
            label3.Text = "Месяц " + sDay.Month;
            label4.Text = "Год " + sDay.Year;
            label5.Text = Convert.ToString(sDay.DayOfWeek);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            DateTime sDay = DateTime.Now;
            DateTime zDay = sDay.AddDays(1);
            richTextBox2.Text += "Завтра " + zDay;
            zDay = sDay.AddDays(7);
            richTextBox2.Text += "\nЧерез неделю " + zDay;
            DateTime tDay = DateTime.Today;
            richTextBox2.Text += "\nТолько дата " + tDay.ToString("d");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime nowDate = DateTime.Today;
            DateTime dt = Convert.ToDateTime(textBox1.Text);
            int age = nowDate.Year - dt.Year;
            richTextBox2.Text = Convert.ToString(age) + " лет";
        }

    }
}
