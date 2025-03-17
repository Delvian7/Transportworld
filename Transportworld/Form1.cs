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
        public Form1()

        {


            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchQuery = TBdrivername.Text.Trim(); // Get text from TBdrivername

            if (!string.IsNullOrEmpty(searchQuery))
            {
                var results = db.Drivers // Replace 'YourDbSet' with your actual DbSet (table)
                    .Where(x => x.Name.Contains(searchQuery)) // Replace 'DriverName' with your actual column name
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
    
            
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TBdrivername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Enter key pressed
            {
                string searchQuery = TBdrivername.Text.Trim();

                if (!string.IsNullOrEmpty(searchQuery))
                {
                    var results = db.Drivers // ✅ Uses 'Drivers' as your DbSet (dbo.Drivers in SQL)
                        .Where(x => x.Name.Contains(searchQuery)) // ✅ Uses 'Name' as the correct column
                        .ToList();

                    if (results.Any())
                    {
                        dataGridView1.DataSource = results;
                    }
                    else
                    {
                        MessageBox.Show("No records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a driver name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}