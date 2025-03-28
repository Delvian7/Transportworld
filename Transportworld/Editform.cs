using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Transportworld
{
    public partial class Editform : Form
    {
        private Dworld1DBEntities2 db = new Dworld1DBEntities2();
        public Editform()
        {
            InitializeComponent();
            this.Load += Editform_Load;
        }

        private void Editform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dworld1DBDataSet.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.dworld1DBDataSet.Drivers);
            BindData();
        }

        private void LoadDriverData()
        {
            var drivers = db.Drivers.ToList(); // Load Driver objects directly

            if (drivers.Any())
            {
                dataGridView1.DataSource = drivers;
                // Make sure the DriverID column is visible
                if (!dataGridView1.Columns.Contains("DriverID"))
                {
                    dataGridView1.AutoGenerateColumns = true; //Ensure all Columns are generated.

                }

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

        private void btSav_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DELVIANJ\\SQLEXPRESS;Initial Catalog=Dworld1DB;Integrated Security=True; pooling=false");
            connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Drivers SET Name = @Name, TRN = @TRN, LicenseNumber = @LicenseNumber WHERE Name = @Name", connection);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@TRN", textBox3.Text);
            cmd.Parameters.AddWithValue("@LicenseNumber", textBox4.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Record Updated Successfully");
            BindData();
        }

        private void BindData()
        {
            // Implement data binding logic here
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCan_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int driverID = (int)dataGridView1.SelectedRows[0].Cells["DriverID"].Value;

                DialogResult result = MessageBox.Show("Are you sure you want to delete this driver?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Data Source=DELVIANJ\\SQLEXPRESS;Initial Catalog=Dworld1DB;Integrated Security=True; pooling=false"; // Replace with your connection string

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string sql = "DELETE FROM Drivers WHERE DriverID = @DriverID";
                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                command.Parameters.AddWithValue("@DriverID", driverID);
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Driver deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadDriverData();
                                }
                                else
                                {
                                    MessageBox.Show("Driver not found or deletion failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a driver to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
