﻿using System;
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

        // Form Load event to handle initialization
        private void MDIParent1_Load(object sender, EventArgs e)
        {
            ShowForm1(); // Ensure Form1 opens once
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
    }
}