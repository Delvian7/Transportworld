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
            // Optionally, load data when the form loads
        }

        private void BtSee_Click(object sender, EventArgs e)
        {
            // Fetch records from the database
            var records = dbContext.Users.ToList(); // Assuming you're showing "Users" table, adjust the table name accordingly

            // Bind the records to the DataGridView
            dataGridView1.DataSource = records;
        }
    }
}
