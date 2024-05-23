using System;
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
        bool calculationComplete = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (calculationComplete)
            {
                pheptinh.Clear();
                calculationComplete = false;
            }
            pheptinh.Text += "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (calculationComplete)
            {
                pheptinh.Clear();
                calculationComplete = false;
            }
            pheptinh.Text += "2";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (calculationComplete)
            {
                pheptinh.Clear();
                calculationComplete = false;
            }
            pheptinh.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (calculationComplete)
            {
                pheptinh.Clear();
                calculationComplete = false;
            }
            pheptinh.Text += "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (calculationComplete)
            {
                pheptinh.Clear();
                calculationComplete = false;
            }
            pheptinh.Text += "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (calculationComplete)
            {
                pheptinh.Clear();
                calculationComplete = false;
            }
            pheptinh.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (calculationComplete)
            {
                pheptinh.Clear();
                calculationComplete = false;
            }
            pheptinh.Text += "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (calculationComplete)
            {
                pheptinh.Clear();
                calculationComplete = false;
            }
            pheptinh.Text += "6";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (calculationComplete)
            {
                pheptinh.Clear();
                calculationComplete = false;
            }
            pheptinh.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (calculationComplete)
            {
                pheptinh.Clear();
                calculationComplete = false;
            }
            pheptinh.Text += "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (calculationComplete)
            {
                pheptinh.Clear();
                calculationComplete = false;
            }
            pheptinh.Text += ".";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float parsedValue;
            if (!float.TryParse(pheptinh.Text, out parsedValue)) return;

            switch (tinhtoan)
            {
                case "cong":
                    data2 = data1 + parsedValue;
                    pheptinh.Text = $"{data1}+{parsedValue}=";
                    ketqua.Text = data2.ToString();
                    break;
                case "tru":
                    data2 = data1 - parsedValue;
                    pheptinh.Text = $"{data1}-{parsedValue}=";
                    ketqua.Text = data2.ToString();
                    break;
                case "nhan":
                    data2 = data1 * parsedValue;
                    pheptinh.Text = $"{data1}*{parsedValue}=";
                    ketqua.Text = data2.ToString();
                    break;
                case "chia":
                    if (parsedValue == 0)
                    {
                        ketqua.Text = "MathERROR";
                    }
                    else
                    {
                        data2 = data1 / parsedValue;
                        pheptinh.Text = $"{data1}÷{parsedValue}=";
                        ketqua.Text = data2.ToString();
                    }
                    break;
            }

            calculationComplete = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (calculationComplete)
            {
                pheptinh.Clear();
                calculationComplete = false;
            }
            if (float.TryParse(pheptinh.Text, out data1))
            {
                tinhtoan = "cong";
                pheptinh.Clear();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pheptinh.Clear();
            ketqua.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (calculationComplete)
            {
                pheptinh.Clear();
                calculationComplete = false;
            }
            if (float.TryParse(pheptinh.Text, out data1))
            {
                tinhtoan = "tru";
                pheptinh.Clear();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (calculationComplete)
            {
                pheptinh.Clear();
                calculationComplete = false;
            }
            if (float.TryParse(pheptinh.Text, out data1))
            {
                tinhtoan = "nhan";
                pheptinh.Clear();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (calculationComplete)
            {
                pheptinh.Clear();
                calculationComplete = false;
            }
            if (float.TryParse(pheptinh.Text, out data1))
            {
                tinhtoan = "chia";
                pheptinh.Clear();
            }
        }

        private void pheptinh_TextChanged(object sender, EventArgs e)
        {
        }

        private void button22_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            FormSolvingEquation equation = new FormSolvingEquation();
            equation.Show();
            this.Hide();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            pheptinh.Text = ketqua.Text;
            calculationComplete = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (float.TryParse(pheptinh.Text, out data1))
    {
        data2 = (float)Math.Sin(data1 * Math.PI / 180); // Assuming input is in degrees
        pheptinh.Text = $"sin({data1}) =";
        ketqua.Text = data2.ToString();
        calculationComplete = true;
    }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (float.TryParse(pheptinh.Text, out data1))
            {
                data2 = (float)Math.Cos(data1 * Math.PI / 180); // Assuming input is in degrees
                pheptinh.Text = $"cos({data1}) =";
                ketqua.Text = data2.ToString();
                calculationComplete = true;
            }
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {
        }
    }
}

