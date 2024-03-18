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
        public string D;
        public string N1;
        public bool  n2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (n2)
            { 
            n2 = false;
                textBox1.Text = "";
            }
            Button B = (Button)sender;
            textBox1.Text = textBox1.Text + B.Text; 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D == "+") 
            {
                res = dn1 + dn2;
            }
            if (D == "-")
            {
                res = dn1 - dn2;
            }
            if (D == "*")
            {
                res = dn1 * dn2;
            }
            if (D == "/" )
            {
                res = dn1 + dn2;
            }
            D = "=";
            n2 = true;
            textBox1.Text = res.ToString();
        }
    }
}
