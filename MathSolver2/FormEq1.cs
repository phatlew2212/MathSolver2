using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace MathSolver2
{
    public partial class FormEq1 : Form
    {
        
        public FormEq1(String fullname)
        {
            InitializeComponent();
            this.txtA.KeyPress += new KeyPressEventHandler(enter_KeyPress);
            this.txtB.KeyPress += new KeyPressEventHandler(enter_KeyPress);
            this.FormClosing += new FormClosingEventHandler(FormEq1_FormClosing);
            this.textBox1.Text = fullname;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            if (a == 0 && b != 0)
            {
                lblError.Visible = true;
                txtKq.Text = "Phương trình vô nghiệm";
            }
            else if (a == 0 && b == 0) txtKq.Text = "Phương trình vô số nghiệm";
            else
            {
                txtKq.Text = string.Format("Phương trình có nghiệm x = {0}", (-b / a));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKq.Text = string.Empty;
        }
        private void enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button4_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEq2 formEq2 = new FormEq2(this.textBox1.Text);
            formEq2.Show();
            this.Hide();
        }
        private void FormEq1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormCalc formCalc = new FormCalc(this.textBox1.Text);
            formCalc.Show();
            this.Hide();
        }
    }
}
