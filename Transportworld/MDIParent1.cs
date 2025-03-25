using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Transportworld;

namespace Transportworld
{
    public partial class MDIParent1 : Form
    {
        private string _username;
        private string _role;
        private Form1 form1Instance = null; // Store reference to prevent duplicates
        private Form2 form2Instance = null; // Store reference to Form2

        // Constructor with username and role passed from LoginForm
        public MDIParent1(string username, string role)
        {
            InitializeComponent();
            _username = username;
            _role = role;
            this.Text = $"Transport World - Welcome, {_username}"; // Show username in title
            this.IsMdiContainer = true;  // Set the form as MDI container
        }

        // Show Form1 only if it hasn't been opened already
        public void ShowForm1()
        {
            if (form1Instance == null || form1Instance.IsDisposed) // Check if already open
            {
                form1Instance = new Form1(_username, _role);
                form1Instance.MdiParent = this;
                form1Instance.Show();
            }
            else
            {
                form1Instance.BringToFront(); // Bring existing instance to front
            }
        }

        // Show Form2 only if it hasn't been opened already
        public void ShowForm2()
        {
            if (form2Instance == null || form2Instance.IsDisposed) // Check if already open
            {
                form2Instance = new Form2(); // Initialize Form2
                form2Instance.MdiParent = this; // Set MDI parent to MDIParent1
                form2Instance.Show(); // Show Form2
            }
            else
            {
                form2Instance.BringToFront(); // Bring existing instance to front
            }
        }

        // Form Load event to handle initialization
        private void MDIParent1_Load(object sender, EventArgs e)
        {
            ShowForm1(); // Ensure Form1 opens once
        }

        // Show Form2 when button is clicked
        private void BtnOpenForm2_Click(object sender, EventArgs e)
        {
            ShowForm2(); // Open Form2 when the button is clicked
        }

        // Open File dialog logic
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

        // Save File dialog logic
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

        // Close application logic
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Toggle toolbar visibility
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        // Toggle status bar visibility
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        // Cascade child forms
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        // Tile child forms vertically
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        // Tile child forms horizontally
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        // Arrange icons
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void manageDriverListingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of Form2
            Form2 form2Instance = new Form2();

            // Set Form2 as a child of MDIParent1
            form2Instance.MdiParent = this;

            // Show Form2 inside the MDI container
            form2Instance.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
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
        

        private void seachDriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1Instance = new Form1(_username, _role);  // Open Form1 with username and role passed
            form1Instance.MdiParent = this;  // Set MDI parent to this (MDIParent1)
            form1Instance.Show();
        }

        private void manageDriversListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();


        }

        private void updateDriverListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    
}