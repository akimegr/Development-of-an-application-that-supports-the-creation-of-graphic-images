using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gurski3n
{
    public partial class Form2 : Form
    {
        public System.Drawing.Color Data()
        {
            return Color.FromArgb(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
        }
        public Form2()
        {
            InitializeComponent();
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            double aa = vScrollBar1.Value;
            double a = (aa / 91) * 255;
            textBox1.Text = Math.Round(a).ToString();
            pictureBox1.BackColor = Color.FromArgb(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            double aa = vScrollBar2.Value;
            double a = ( aa / 91) * 255;
            textBox2.Text = Math.Round(a).ToString();
            pictureBox1.BackColor = Color.FromArgb(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            double aa = vScrollBar3.Value;
            double a = (aa / 91) * 255;
            textBox3.Text = Math.Round(a).ToString();
            pictureBox1.BackColor = Color.FromArgb(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "0";
            pictureBox1.BackColor = Color.FromArgb(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                textBox2.Text = "0";
            pictureBox1.BackColor = Color.FromArgb(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
                textBox3.Text = "0";
            pictureBox1.BackColor = Color.FromArgb(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
