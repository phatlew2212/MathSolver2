
using System.Data.SQLite;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string connectionString = "Data Source=db.db";

            // Tạo kết nối
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Mở kết nối
                connection.Open();
                string query = "SELECT COUNT(*) FROM users WHERE Username = @username AND Password = @password";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userCount == 1)
                    {
                        MessageBox.Show("Login successful!");
                        FormCalculator formCalculator = new FormCalculator(); 
                        formCalculator.Show();
                        this.Hide();
                        // Redirect to another form or perform some action
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
        }
    }

}
