using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Transportworld;

namespace Transportworld
{
    public partial class LoginForm : Form
    {
        private Dworld1DBEntities2 db = new Dworld1DBEntities2(); // Database context

        // Property to indicate if login was successful
        public bool LoginSuccessful { get; private set; }
        public string Username { get; internal set; }
        public string Role { get; internal set; }

        // Constructor
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            string username = TBusername.Text.Trim(); // Get username from TextBox
            string password = TBPassword.Text.Trim(); // Get password from TextBox

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if user exists in the database
            var user = db.Users
                .Where(u => u.Username == username && u.Password == password)
                .Select(u => new { u.Username, u.Role }) // Select Username & Role
                .FirstOrDefault();

            if (user != null)
            {
                // Set login successful flag and close the login form
                LoginSuccessful = true;

                // Store user information to pass to Form1 (optional)
                Form1 mainForm = new Form1(user.Username, user.Role);
                this.Hide(); // Hide the LoginForm
                mainForm.Show(); // Show Form1

                MessageBox.Show($"Welcome, {user.Username}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Add any initialization logic here if needed.
        }
    }
}