using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec3Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int num1, num2, num3;
            if (a>b)
            {
                if (a>c)
                {
                    num1 = a;
                    if (b>c)
                    {
                        num2 = b;
                        num3 = c;
                    }
                    else
                    {
                        num2 = c;
                        num3 = b;
                    }
                }
                else
                {
                    num1 = c;
                    num2 = a;
                    num3 = b;
                }
            }
            else
            {
                if (b>c)
                {
                    num1 = b;
                    if (a>c)
                    {
                        num2 = a;
                        num3 = c;
                    }
                    else
                    {
                        num2 = c;
                        num3 = a;
                    }
  
                }
                else
                {
                    num1 = c;
                    num2 = b;
                    num3 = a;
                }
            }

            MessageBox.Show(num1+", "+num2+", "+num3);
        }
    }
}
