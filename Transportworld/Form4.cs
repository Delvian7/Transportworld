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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Transportworld
{
    public partial class Form4 : Form
    {
        private Dworld1DBEntities2 db = new Dworld1DBEntities2();
        private string _driverName;
        
        public Driver NewDriver { get; set; }

        // Constructor to receive driver's name (Edit Mode)
        public Form4(string driverName)
        {
            InitializeComponent();
            _driverName = driverName;
            

            

            this.Load += Form4_Load;
        }

        // Default constructor (Add Mode)
        public Form4()
        {
            InitializeComponent();
           
            this.Load += Form4_Load;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Any additional initialization on form load
        }

        private void populateDrivers(string driverName)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DELVIANJ\\SQLEXPRESS;Initial Catalog=Dworld1DB;Integrated Security=True; pooling=false");
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Drivers (Name, TRN, LicenseNumber) VALUES (@Name, @TRN, @LicenseNumber)", connection);
            cmd.Parameters.AddWithValue("@Name", textbox2.Text);
            cmd.Parameters.AddWithValue("@TRN", textbox3.Text);
            cmd.Parameters.AddWithValue("@LicenseNumber", textbox4.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Record inserted successfully.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btCan_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
