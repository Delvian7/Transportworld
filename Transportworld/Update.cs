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
    public partial class Update : Form
    {
        private Dworld1DBEntities2 db = new Dworld1DBEntities2();
        public Update()
        {
            InitializeComponent();
            this.Load += Update_Load;
        }

        private void Update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dworld1DBDataSet.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.dworld1DBDataSet.Drivers);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DELVIANJ\\SQLEXPRESS;Initial Catalog=Dworld1DB;Integrated Security=True; pooling=false");
            connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Drivers SET Name = @Name, TRN = @TRN, LicenseNumber = @LicenseNumber WHERE DriverID = @DriverID", connection);
            cmd.Parameters.AddWithValue("@DriverID", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@TRN", textBox3.Text);
            cmd.Parameters.AddWithValue("@LicenseNumber", textBox4.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Driver Updated Successfully");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
