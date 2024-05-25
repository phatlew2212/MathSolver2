﻿
using System.Data.SQLite;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace MathSolver2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.txtUsername.TextChanged += new System.EventHandler(this.hideError);
            this.txtPassword.TextChanged += new System.EventHandler(this.hideError);
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.txtUsername.KeyPress += new KeyPressEventHandler(enter_KeyPress);
            this.txtPassword.KeyPress += new KeyPressEventHandler(enter_KeyPress);
            this.checkBox1.KeyPress += new KeyPressEventHandler(enter_KeyPress);
            this.FormClosing += new FormClosingEventHandler(FormSignUp_FormClosing);

        }
        // kết nối db
        public SQLiteConnection getConnection()
        {
            string connectionString = "Data Source=db.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return connection;

    }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            using (SQLiteConnection connection = getConnection())
            {
             
                string query = "SELECT COUNT(*) FROM users WHERE Username = @username AND Password = @password";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userCount == 1)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        FormCalc formCalc = new FormCalc();
                        formCalc.Show();
                        this.Hide();
                    }
                    else
                    {
                        this.label2.Show();
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            formSignUp.Show();
            this.Hide();
        }
        // hiện và ẩn thông báo lỗi
        private void hideError(object sender, EventArgs e)
        {
            this.label2.Hide();
            this.label2.Hide();
        }


        // Sự kiện CheckedChanged của CheckBox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
      
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                
                txtPassword.PasswordChar = '*';
            }
        }
        // sự kiện nhấn enter
        private void enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnLogin_Click(sender, e);
            }
        }
        private void FormSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
