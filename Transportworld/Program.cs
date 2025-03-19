using System;
using System.Windows.Forms;

namespace Transportworld
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create and show the login form first
            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm); // Run LoginForm first

            // Check if login was successful before opening MDIParent1
            if (loginForm.LoginSuccessful)
            {
                Application.Run(new MDIParent1(loginForm.Username, loginForm.Role)); // Open the main MDI form after successful login
            }
        }
    }
}