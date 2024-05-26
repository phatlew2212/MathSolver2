using System;
using System.Security.AccessControl;
using System.Windows.Forms;
namespace MathSolver2
{
    public partial class FormCalc : Form
    {

        Double result = 0;
        string oper = string.Empty;
        string fstNum, secNum;
        bool Complt = false;
        double ans = 0;
        public FormCalc(string fullname)
        {

            InitializeComponent();
            this.textBox1.Text = fullname;
            this.FormClosing += new FormClosingEventHandler(FormCalc_FormClosing);
        }


        private void btnNUM(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (txtBot.Text == "0" || Complt)
                txtBot.Text = string.Empty;
            Complt = false;
            if (b.Text == ".")
            {
                if (!txtBot.Text.Contains("."))
                    txtBot.Text = txtBot.Text + b.Text;
            }
            else
            {
                txtBot.Text += b.Text;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormEq2 formEq2 = new FormEq2(this.textBox1.Text);
            formEq2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEq1 formEq1 = new FormEq1(this.textBox1.Text);
            formEq1.Show();
            this.Hide();
        }

        private void btnOper(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (result != 0)
            {
                btnEqual.PerformClick();
                Complt = true;
                oper = b.Text;
                lblOp.Text = result + " " + oper;
            }
            else
            {
                oper = b.Text;
                result = double.Parse(txtBot.Text);
                Complt = true;
                lblOp.Text = result + "  " + oper;
            }
            fstNum = lblOp.Text;

        }

        private void txtBot_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCalc_Load(object sender, EventArgs e)
        {

        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtBot.Clear();
            result = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secNum = txtBot.Text;
            lblOp.Text = "";
            switch (oper)
            {
                case "+":
                    txtBot.Text = (result + Double.Parse(txtBot.Text)).ToString();
                    break;
                case "-":
                    txtBot.Text = (result - Double.Parse(txtBot.Text)).ToString();
                    break;
                case "x":
                    txtBot.Text = (result * Double.Parse(txtBot.Text)).ToString();
                    break;
                case "/":
                    if (txtBot.Text != "0")
                    {
                        txtBot.Text = (result / double.Parse(txtBot.Text)).ToString();
                    }
                    else
                    {
                       
                        txtBot.Text = "MathERROR";
                    }
                    break;
                default:
                    break;
            }
            result = Double.Parse(txtBot.Text);
            ans = result;
            oper = "";

            btnCLearHistory.Visible = true;
            rtbHistory.AppendText(fstNum + "  " + secNum + " = " + txtBot.Text + "\n" + "\n" );
            lblHis.Text = "";
           
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
           if (txtBot.Text.Length > 0)
            {
                txtBot.Text = txtBot.Text.Remove(txtBot.Text.Length - 1, 1);
            }
            if (txtBot.Text.Length == 0)
            {
                txtBot.Text = "0";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCLearHistory_Click(object sender, EventArgs e)
        {
            rtbHistory.Clear();
            if(lblHis.Text == "")
            {
                lblHis.Text = "There's no history yet";
            }
            btnCLearHistory.Visible =false;
            rtbHistory.ScrollBars = 0;
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            txtBot.Text = Math.Sin(double.Parse(txtBot.Text) * Math.PI / 180).ToString();
            ans = double.Parse(txtBot.Text);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            txtBot.Text = Math.Cos(double.Parse(txtBot.Text) * Math.PI / 180).ToString();
            ans = double.Parse(txtBot.Text);
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            txtBot.Text = (result * double.Parse(txtBot.Text) / 100).ToString();
            ans = double.Parse(txtBot.Text);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            txtBot.Text = Math.Sqrt(double.Parse(txtBot.Text)).ToString();
            ans = double.Parse(txtBot.Text);
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            txtBot.Text = ans.ToString();
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            txtBot.Text = Math.Log(double.Parse(txtBot.Text)).ToString();
            ans = double.Parse(txtBot.Text);
        }

        private void C(object sender, EventArgs e)
        {
            txtBot.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
        private void FormCalc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
