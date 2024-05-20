using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathSolver2
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }
        float data1, data2;
        string tinhtoan;
        private void button1_Click(object sender, EventArgs e)
        {
            pheptinh.Text = pheptinh.Text + "9";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pheptinh.Text = pheptinh.Text + "2";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            pheptinh.Text = pheptinh.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pheptinh.Text = pheptinh.Text + "1";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pheptinh.Text = pheptinh.Text + "3";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            pheptinh.Text = pheptinh.Text + "4";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            pheptinh.Text = pheptinh.Text + "5";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            pheptinh.Text = pheptinh.Text + "6";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            pheptinh.Text = pheptinh.Text + "7";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pheptinh.Text = pheptinh.Text + "8";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pheptinh.Text = pheptinh.Text + ".";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(tinhtoan == "cong")
            {
                data2 = data1 + float.Parse(pheptinh.Text);
                pheptinh.Text = data1.ToString() + "+" + float.Parse(pheptinh.Text) + "=";
                ketqua.Text = data2.ToString();
            }
            if (tinhtoan == "tru")
            {
                data2 = data1 - float.Parse(pheptinh.Text);
                pheptinh.Text = data1.ToString() + "-" + float.Parse(pheptinh.Text) + "=";
                ketqua.Text = data2.ToString();
            }
            if (tinhtoan == "nhan")
            {
                data2 = data1 * float.Parse(pheptinh.Text);
                pheptinh.Text = data1.ToString() + "*" + float.Parse(pheptinh.Text) + "=";
                ketqua.Text = data2.ToString();
            }
            if (tinhtoan == "chia")
            {
                if(float.Parse(pheptinh.Text) == 0)
                {
                    ketqua.Text = "MathERROR";
                }
                else
                {
                    data2 = data1 / float.Parse(pheptinh.Text);
                    pheptinh.Text = data1.ToString() + "÷" + float.Parse(pheptinh.Text) + "=";
                    ketqua.Text = data2.ToString();
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            tinhtoan = "cong";
            data1 = float.Parse(pheptinh.Text);
            pheptinh.Text = data1.ToString() + "+";
            pheptinh.Clear();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            pheptinh.Text = pheptinh.Text + "(";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            pheptinh.Text = pheptinh.Text + "0";


        }

        private void button16_Click(object sender, EventArgs e)
        {
            pheptinh.Clear();
            ketqua.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tinhtoan = "tru";
            data1 = float.Parse(pheptinh.Text);
            pheptinh.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tinhtoan = "nhan";
            data1 = float.Parse(pheptinh.Text);
            pheptinh.Clear();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tinhtoan = "chia";
            data1 = float.Parse(pheptinh.Text);
            pheptinh.Clear();

        }

        private void pheptinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
