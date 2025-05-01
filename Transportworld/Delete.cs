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
    public partial class Delete : Form
    {
        private Dworld1DBEntities2 db = new Dworld1DBEntities2();
        public Delete()
        {
            InitializeComponent();
            this.Load += Delete_Load;
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dworld1DBDataSet.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.dworld1DBDataSet.Drivers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DELVIANJ\\SQLEXPRESS;Initial Catalog=Dworld1DB;Integrated Security=True; pooling=false");
            connection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Drivers WHERE DriverID = @DriverID", connection);
            cmd.Parameters.AddWithValue("@DriverID", Convert.ToInt32(textBox1.Text));
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Driver Deleted Successfully");
        }
    }
}
