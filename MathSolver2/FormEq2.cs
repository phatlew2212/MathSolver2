using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace MathSolver2
{
    public partial class FormEq2 : Form
    {
        public FormEq2()
        {
            InitializeComponent();
            this.txtA.KeyPress += new KeyPressEventHandler(enter_KeyPress);
            this.txtB.KeyPress += new KeyPressEventHandler(enter_KeyPress);
            this.txtC.KeyPress += new KeyPressEventHandler(enter_KeyPress);
        }
        private void enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button4_Click(sender, e);
            }
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b, c, delta, x1, x2;
            string result = "";
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            if (a == 0)
            {

                if (b == 0)
                {
                    if (c == 0)
                    {
                        result = "Phương trình có vô số nghiệm";
                    }
                    else //C khác 0
                    {
                        lblError.Visible = true;
                        result = "Phương trình vô nghiệm";
                    }
                }
                else //b khác 0
                {
                    result = string.Format("Phương trình có nghiệm x = {0}", (-c / b));
                }
            }
            else // a khác 0
            {
                delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    result = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {
                    result = string.Format("Phương trình có nghiệm kép x = {0}", -b / 2 * a);
                }
                else
                {
                    x1 = ((-b + Math.Sqrt(delta)) / (2 * a));
                    x2 = ((-b - Math.Sqrt(delta)) / (2 * a));
                    result = string.Format("Phương trình có 2 nghiệm: x1 = {0}, x2 = {1}", x1, x2);
                }
            }
            txtKq.Text = result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();  
            txtC.Clear();
            txtKq.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormEq1 formEq1 = new FormEq1();
            formEq1.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormCalc formCalc = new FormCalc();
            formCalc.Show();
            this.Hide();
        }
    }
}
