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
            string username = TBusername.Text.Trim(); 
            string password = TBPassword.Text.Trim(); 

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            var user = db.Users
                .Where(u => u.Username == username && u.Password == password)
                .Select(u => new { u.Username, u.Role }) 
                .FirstOrDefault();

            if (user != null)
            {
                
                LoginSuccessful = true;
                Username = user.Username; 
                Role = user.Role; 

                
                MDIParent1 mainForm = new MDIParent1(Username, Role); 

                this.Hide(); 
                mainForm.Show(); 
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}