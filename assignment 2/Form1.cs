using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this code enables the resistors to add themselves together.
            try
            {
                double r1 = double.Parse(textBox1.Text);
                double r2 = double.Parse(textBox2.Text);
                double r3 = double.Parse(textBox3.Text);
                double answer = r1 + r2 + r3;
                label8.Text = answer.ToString();
            }


            catch
            {
                MessageBox.Show("please enter a number");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                double r1 = double.Parse(textBox4.Text);
                double r2 = double.Parse(textBox5.Text);
                double top = r1 * r2;
                double bottom = r1 + r2;
                double answer = top / bottom;
                label12.Text = answer.ToString();
            }
            catch
            {
                MessageBox.Show("please enter a number");
            }
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double r1 = double.Parse(textBox6.Text);
                double r2 = double.Parse(textBox7.Text);
                double answer = r1 + r2;
                label16.Text = answer.ToString();

            }
            catch
            {
                MessageBox.Show("please enter a number");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double r1 = double.Parse(textBox8.Text);
                double r2 = double.Parse(textBox9.Text);
                double r3 = double.Parse(textBox10.Text);
                double r4 = double.Parse(textBox11.Text);
                double answer = r1 + r2 + r3 + r4;
                label22.Text = answer.ToString();

            }
            catch
            {
                MessageBox.Show("please enter a number");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double r1 = double.Parse(textBox12.Text);
                double r2 = double.Parse(textBox13.Text);
                double r3 = double.Parse(textBox14.Text);
                double r4 = double.Parse(textBox15.Text);
                double r5 = double.Parse(textBox16.Text);
                double answer = r1 + r2 + r3 + r4 + r5;
                label29.Text = answer.ToString();

            }
            catch
            {
                MessageBox.Show("please enter a number");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double r1 = double.Parse(textBox17.Text);
                double r2 = double.Parse(textBox18.Text);
                double r3 = double.Parse(textBox19.Text);
                double answer = 1.0 / (1.0 / r1 + 1.0 / r2 + 1.0 / r3);
                label34.Text = answer.ToString();
            }
            catch
            {
                MessageBox.Show("please enter a number");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                double r1 = double.Parse(textBox20.Text);
                double r2 = double.Parse(textBox21.Text);
                double r3 = double.Parse(textBox22.Text);
                double r4 = double.Parse(textBox23.Text);
                double answer = 1.0 / (1.0 / r1 + 1.0 / r2 + 1.0 / r3 + 1.0 / r4);
                label40.Text = answer.ToString();
            }
            catch
            {
                MessageBox.Show("please enter a number");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                double r1 = double.Parse(textBox24.Text);
                double r2 = double.Parse(textBox25.Text);
                double r3 = double.Parse(textBox26.Text);
                double r4 = double.Parse(textBox27.Text);
                double r5 = double.Parse(textBox28.Text);
                double answer = 1.0 / (1.0 / r1 + 1.0 / r2 + 1.0 / r3 + 1.0 / r4 + 1.0 / r5);
                label47.Text = answer.ToString();
            }
            catch
            {
                MessageBox.Show("please enter a number");
            }

        }
    }
}
