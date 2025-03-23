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
        private Dworld1DBEntities2 db = new Dworld1DBEntities2();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var drivers = db.Drivers
                .Select(d => new
                {
                    DriverName = d.Name,
                    VehicleType = d.Vehicles.Select(v => v.VehicleType).FirstOrDefault(),
                    RegistrationNumber = d.Vehicles.Select(v => v.RegistrationNumber).FirstOrDefault(),
                    Route = d.Vehicles.Select(v => v.Route).FirstOrDefault()
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
    }
}

