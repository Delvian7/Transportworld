using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Transportworld
{
    public partial class Form3 : Form
    {
        private Dworld1DBEntities2 db = new Dworld1DBEntities2();

        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dworld1DBDataSet.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.Fill(this.dworld1DBDataSet.Vehicles);
            // TODO: This line of code loads data into the 'dworld1DBDataSet.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.dworld1DBDataSet.Drivers);

        }



        private void LoadDriverData()
        {
            var drivers = db.Drivers
                .Select(d => new
                {
                    DriverName = d.Name,
                    VehicleType = d.Vehicles.Select(v => v.VehicleType).FirstOrDefault(),
                    RegistrationNumber = d.Vehicles.Select(v => v.RegistrationNumber).FirstOrDefault(),
                    Route = d.Vehicles.Select(v => v.Route).FirstOrDefault(),
                    Trn = d.TRN
                })
                .ToList();

            if (drivers.Any())
            {
                dataGridView1.DataSource = drivers;
            }
            else
            {
                MessageBox.Show("No driver records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click event if needed
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btbEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string driverName = dataGridView1.SelectedRows[0].Cells["DriverName"].Value.ToString();
                var driver = db.Drivers.FirstOrDefault(d => (string)d.Name == driverName);

                if (driver != null)
                {
                    driver.Name = "Edited Name"; // Example edit
                    db.SaveChanges();
                    LoadDriverData();
                    MessageBox.Show("Driver record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editform editform = new Editform();
            editform.MdiParent = this.MdiParent;
            editform.Show();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.MdiParent = this.MdiParent;
            form4.Show();

        }
        
        
        


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int driverID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["DriverID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this driver?",
                                                      "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var driver = db.Drivers.FirstOrDefault(d => d.DriverID == driverID);

                    if (driver != null)
                    {
                        db.Drivers.Remove(driver);
                        db.SaveChanges();
                        MessageBox.Show("Driver deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDriverData(); // Refresh DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Driver not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
        }
    }
}
