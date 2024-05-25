using System;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace MathSolver2
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
            txtName.TextChanged += new EventHandler(HideErrors);
            txtUsername.TextChanged += new EventHandler(HideErrors);
            txtPassword.TextChanged += new EventHandler(HideErrors);
            txtConfirmPassword.TextChanged += new EventHandler(HideErrors);
            txtGmail.TextChanged += new EventHandler(HideErrors);

            this.txtUsername.KeyPress += new KeyPressEventHandler(FormSignUp_KeyPress);
            this.txtPassword.KeyPress += new KeyPressEventHandler(FormSignUp_KeyPress);
            this.txtConfirmPassword.KeyPress += new KeyPressEventHandler(FormSignUp_KeyPress);
            this.txtGmail.KeyPress += new KeyPressEventHandler(FormSignUp_KeyPress);

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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string fullName = txtName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string email = txtGmail.Text;
            string salt = "$2a$12$X5EJWiB6XrULuZdhvf4vZO";
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password,salt);
            if (!notNullPassAndUser(username, password))
            {
                this.notNullUsernameAndPass.Show();
                return;
            }

            if (IsUsernameTaken(username))
            {
                this.existUsername.Show();
                return;
            }
            if (password != confirmPassword)
            {
                this.errorConfirmPassword.Show();
                return;
            }
            if (!IsValidEmail(email))
            {
                this.errorEmail.Show() ;
                return;
            }
            RegisterUser(fullName, username, hashedPassword, email);
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return true;
            }

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsUsernameTaken(string username)
        {

            using (SQLiteConnection conn = getConnection())
            {
                string query = "SELECT COUNT(*) FROM users WHERE username = @username";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        private bool notNullPassAndUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            return true;
        }

        private void RegisterUser(string fullName, string username, string password, string email)
        {
            using (SQLiteConnection conn = getConnection())
            {
                string query = "INSERT INTO users (fullname, username, password, email) VALUES (@fullname, @username, @password, @email)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@fullname", fullName);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đăng ký thành công! ");
                        FormLogin formLogin = new FormLogin();
                        formLogin.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void linkLabel1_LinkClicked(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
        private void HideErrors(object sender, EventArgs e)
        {
            this.errorEmail.Hide();
            this.errorConfirmPassword.Hide();
            this.existUsername.Hide();
            this.notNullUsernameAndPass.Hide();
        }
        private void FormSignUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSignUp_Click(sender, e);
            }
        }
        private void FormSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

