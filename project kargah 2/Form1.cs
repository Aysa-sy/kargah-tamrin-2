using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_kargah_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y, sum;
            x = Convert.ToInt16(textBox1.Text);
            y = Convert.ToInt16(textBox2.Text);
            sum = x + y;
            label3.Text = "sum is :" + "" + Convert.ToString(sum);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x, y, sum;
            x = Convert.ToInt16(textBox1.Text);
            y = Convert.ToInt16(textBox2.Text);
            sum = x * y;
            label3.Text = "product is :" + "" + Convert.ToString(sum);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x, y, sum;
            x = Convert.ToInt16(textBox1.Text);
            y = Convert.ToInt16(textBox2.Text);
            sum = x - y;
            label3.Text = "minus is :" + "" + Convert.ToString(sum);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x, y, sum;
            x = Convert.ToInt16(textBox1.Text);
            y = Convert.ToInt16(textBox2.Text);
            sum = x / y;
            label3.Text = "division is :" + "" + Convert.ToString(sum);
        }
    }
}
