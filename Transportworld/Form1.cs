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
        private string _username;
        private string _role;

        // Constructor without parameters (default constructor)
        public Form1()
        {
            InitializeComponent();
        }

        // Constructor with username and role parameters
        public Form1(string username, string role)
        {
            InitializeComponent();
            _username = username;
            _role = role;

     
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

        private void AddTabsDynamically()
        {
            // Create a new TabControl
            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill; // Make it fill the form
            tabControl.Name = "mainTabControl"; // Name it to avoid duplicate additions

            // Create Tab Page 1 (Dashboard)
            TabPage tab1 = new TabPage("Dashboard");
            Label label1 = new Label()
            {
                Text = "Welcome to Dashboard",
                Location = new System.Drawing.Point(20, 20),
                AutoSize = true
            };
            tab1.Controls.Add(label1); // Add label to tab1

            // Create Tab Page 2 (Settings)
            TabPage tab2 = new TabPage("Settings");
            Label label2 = new Label()
            {
                Text = "Settings Page",
                Location = new System.Drawing.Point(20, 20),
                AutoSize = true
            };
            tab2.Controls.Add(label2); // Add label to tab2

            // Add tabs to TabControl
            tabControl.TabPages.Add(tab1);
            tabControl.TabPages.Add(tab2);

            // Ensure the tabControl is not added multiple times
            if (!this.Controls.ContainsKey("mainTabControl"))
            {
                this.Controls.Add(tabControl);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

