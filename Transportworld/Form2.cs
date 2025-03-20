using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportworld
{
    public partial class Form2 : Form
    {
        private Dworld1DBEntities2 dbContext = new Dworld1DBEntities2();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Optionally, you can load data when the form loads
        }


        private void Btsee_Click_1(object sender, EventArgs e)
        {
            try
            {
                var records = dbContext.Drivers
                    .Select(d => new
                    {
                        DriverName = d.Name,
                        VehicleType = d.Vehicles.Select(v => v.VehicleType).FirstOrDefault(),
                        RegistrationNumber = d.Vehicles.Select(v => v.RegistrationNumber).FirstOrDefault(),
                        Route = d.Vehicles.Select(v => v.Route).FirstOrDefault()
                    })
                    .ToList();

                if (records.Any())
                {
                    dataGridView1.DataSource = records; // Show data in DataGridView
                }
                else
                {
                    MessageBox.Show("No records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null; // Clear DataGridView if no results
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}