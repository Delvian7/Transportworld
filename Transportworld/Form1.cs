using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportworld
{
    public partial class Form1 : Form
    {
        private Dworld1DBEntities2 db = new Dworld1DBEntities2();
        private LoginForm _loginForm; // Login form instance
        private string _username;
        private string _role;
        private string username;
        private string role;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string username, string role)
        {
            this.username = username;
            this.role = role;
        }

        // Show LoginForm when Form1 is initialized
        private void Form1_Load(object sender, EventArgs e)
        {
            // Create an instance of the LoginForm
            _loginForm = new LoginForm();

            // Show the login form as a dialog (blocks interaction with Form1 until closed)
            _loginForm.ShowDialog();

            // Check if the login was successful by checking user data passed from LoginForm
            if (_loginForm.LoginSuccessful)
            {
                // If login is successful, Form1 can proceed to load
                _username = _loginForm.Username; // Store the username passed from the login form
                _role = _loginForm.Role; // Store the role passed from the login form

                MessageBox.Show($"Login successful. Welcome, {_username}!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // If login failed, close Form1
                MessageBox.Show("Login failed. Please check your credentials.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the application if login fails
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchQuery = TBdrivername.Text.Trim(); // Get text from TBdrivername

            if (!string.IsNullOrEmpty(searchQuery))
            {
                var results = db.Drivers // Querying Drivers table
                    .Where(d => d.Name.Contains(searchQuery)) // Filter by driver name
                    .Select(d => new
                    {
                        DriverName = d.Name,
                        VehicleType = d.Vehicles.Select(v => v.VehicleType).FirstOrDefault(), // Vehicle type
                        RegistrationNumber = d.Vehicles.Select(v => v.RegistrationNumber).FirstOrDefault(), // Vehicle registration number
                        Route = d.Vehicles.Select(v => v.Route).FirstOrDefault() // Vehicle route
                    })
                    .ToList();

                if (results.Any())
                {
                    dataGridView1.DataSource = results; // Show results in DataGridView
                }
                else
                {
                    MessageBox.Show("No records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null; // Clear DataGridView if no results
                }
            }
            else
            {
                MessageBox.Show("Please enter a driver name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TBdrivername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Enter key pressed
            {
                string searchQuery = TBdrivername.Text.Trim();

                if (!string.IsNullOrEmpty(searchQuery))
                {
                    var results = db.Drivers // Querying Drivers table
                        .Where(d => d.Name.Contains(searchQuery)) // Filter by driver name
                        .Select(d => new
                        {
                            DriverName = d.Name,
                            VehicleType = d.Vehicles.Select(v => v.VehicleType).FirstOrDefault(), // Vehicle type
                            RegistrationNumber = d.Vehicles.Select(v => v.RegistrationNumber).FirstOrDefault(), // Vehicle registration number
                            Route = d.Vehicles.Select(v => v.Route).FirstOrDefault() // Vehicle route
                        })
                        .ToList();

                    if (results.Any())
                    {
                        dataGridView1.DataSource = results; // Show results in DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null; // Clear DataGridView if no results
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a driver name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void TBdrivername_TextChanged(object sender, EventArgs e)
        {

        }

        // Other event handlers for labels and text changes...
    }
}