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
    }
}
