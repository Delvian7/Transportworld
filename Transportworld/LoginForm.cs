using System;
using System.Linq;
using System.Windows.Forms;
using Transportworld;

namespace Transportworld
{
    public partial class LoginForm : Form
    {
        private Dworld1DBEntities2 db = new Dworld1DBEntities2();
        public bool LoginSuccessful { get; private set; }
        public string Username { get; private set; }
        public string Role { get; private set; }

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
                // Set login successful flag
                LoginSuccessful = true;
                Username = user.Username; // Store username
                Role = user.Role; // Store role

                // Open MDI Parent form after successful login
                MDIParent1 mainForm = new MDIParent1(Username, Role); // Pass Username and Role

                this.Hide(); // Hide LoginForm
                mainForm.Show(); // Show the MDI Parent form
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Additional initialization logic can go here if needed.
        }
    }
}