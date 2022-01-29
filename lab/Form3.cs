using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gurski11
{
    public partial class Form3 : Form
    {

        int corx = 0;
        int cory = 0;
        
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.corx = Cursor.Position.X; //Convert.ToInt32(Convert.ToDouble(Cursor.Position.X) / 600 * 900) - 200;
            this.cory = Cursor.Position.Y; //Convert.ToInt32(Convert.ToDouble(Cursor.Position.Y) / 400 * 600) - 200;
            //  this.pictureBox1_Paint(sender, PaintEventArgs);
            PaintEventArgs p = new PaintEventArgs(pictureBox1.CreateGraphics(), pictureBox1.Bounds); //Компонент на котором нужно рисовать и область на которой нужно рисовать
            pictureBox1_Paint(sender, p);

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (radioButton1.Checked)
            {
                Rectangle circle = new Rectangle(this.corx - 120, this.cory - 120, 100, 100);
                e.Graphics.FillEllipse(Brushes.Blue, circle);
            }else if (radioButton2.Checked)
            {
                Rectangle triangle = new Rectangle(this.corx - 170, this.cory - 170, 200, 100);
                e.Graphics.FillPie(Brushes.Yellow, triangle, 0.0F, 45.0F);
            }
            else if (radioButton3.Checked)
            {
                Rectangle rec = new Rectangle(this.corx - 170, this.cory - 170, 200, 200);
                e.Graphics.FillRectangle(Brushes.Red, rec);

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
