using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportworld
{
    public partial class CreateVehicle : Form
        
    {
        private Dworld1DBEntities2 db = new Dworld1DBEntities2();

        public CreateVehicle()
        {
            InitializeComponent();
            this.Load += CreateVehicle_Load;
        }

        private void CreateVehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dworld1DBDataSet.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.Fill(this.dworld1DBDataSet.Vehicles);

        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.facebook.com/");
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.twitter.com/");
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.instagram.com/");
        }

        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening URL: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.facebook.com/");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.Twitter.com/");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.Instagram.com/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.youtube.com/@delvianTv/");
        }
    }
}
