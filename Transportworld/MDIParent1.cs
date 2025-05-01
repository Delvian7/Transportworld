using System;
using System.Windows.Forms;

namespace Transportworld
{
    public partial class MDIParent1 : Form
    {
        private string _username;
        private string _role;

        // Form instances (singleton-style)
        private Form1 form1Instance = null;
        private Form2 form2Instance = null;
        private Form3 form3Instance = null;
        private Form5 form5Instance = null;
        private Delete deleteFormInstance = null;
        private Update updateFormInstance = null;
        private CreateVehicle createVehicleFormInstance = null;

        public MDIParent1(string username, string role)
        {
            InitializeComponent();
            _username = username;
            _role = role;
            this.Text = $"Transport World - Welcome, {_username}";
            this.IsMdiContainer = true;
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            ShowForm1();
        }

        // === Form Opening Methods ===

        private void ShowForm1()
        {
            if (form1Instance == null || form1Instance.IsDisposed)
            {
                form1Instance = new Form1(_username, _role);
                form1Instance.MdiParent = this;
                form1Instance.Show();
            }
            else
            {
                form1Instance.BringToFront();
            }
        }

        private void ShowForm2()
        {
            if (form2Instance == null || form2Instance.IsDisposed)
            {
                form2Instance = new Form2();
                form2Instance.MdiParent = this;
                form2Instance.Show();
            }
            else
            {
                form2Instance.BringToFront();
            }
        }

        private void ShowForm3()
        {
            if (form3Instance == null || form3Instance.IsDisposed)
            {
                form3Instance = new Form3();
                form3Instance.MdiParent = this;
                form3Instance.Show();
            }
            else
            {
                form3Instance.BringToFront();
            }
        }

        private void ShowForm5()
        {
            if (form5Instance == null || form5Instance.IsDisposed)
            {
                form5Instance = new Form5();
                form5Instance.MdiParent = this;
                form5Instance.Show();
            }
            else
            {
                form5Instance.BringToFront();
            }
        }

        private void ShowDeleteForm()
        {
            if (deleteFormInstance == null || deleteFormInstance.IsDisposed)
            {
                deleteFormInstance = new Delete();
                deleteFormInstance.MdiParent = this;
                deleteFormInstance.Show();
            }
            else
            {
                deleteFormInstance.BringToFront();
            }
        }

        private void ShowUpdateForm()
        {
            if (updateFormInstance == null || updateFormInstance.IsDisposed)
            {
                updateFormInstance = new Update();
                updateFormInstance.MdiParent = this;
                updateFormInstance.Show();
            }
            else
            {
                updateFormInstance.BringToFront();
            }
        }

        private void ShowCreateVehicleForm()
        {
            if (createVehicleFormInstance == null || createVehicleFormInstance.IsDisposed)
            {
                createVehicleFormInstance = new CreateVehicle();
                createVehicleFormInstance.MdiParent = this;
                createVehicleFormInstance.Show();
            }
            else
            {
                createVehicleFormInstance.BringToFront();
            }
        }

        // === Menu / Button Handlers calling the above ===

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm1();
        }

        private void seachDriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm1();
        }

        private void manageDriverListingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm2();
        }

        private void manageDriversListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm2();
        }

        private void updateDriverListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm3();
        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm5();
        }

        private void deleteDriverRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDeleteForm();
        }

        private void updateDriverRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUpdateForm();
        }

        private void vehicleRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCreateVehicleForm();
        }

        // === Default Windows Forms Actions (unchanged) ===

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
            }
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }
}
