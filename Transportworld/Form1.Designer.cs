﻿using System;

namespace Transportworld
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBdrivername = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UpdButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "TransportWorld";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Driver Name";
            // 
            // TBdrivername
            // 
            this.TBdrivername.Location = new System.Drawing.Point(128, 172);
            this.TBdrivername.Name = "TBdrivername";
            this.TBdrivername.Size = new System.Drawing.Size(250, 22);
            this.TBdrivername.TabIndex = 2;
            this.TBdrivername.TextChanged += new System.EventHandler(this.TBdrivername_TextChanged);
            this.TBdrivername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBdrivername_KeyPress);
            // 
            // Search
            // 
            this.Search.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Search.FlatAppearance.BorderSize = 7;
            this.Search.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(438, 133);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(300, 61);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(128, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(942, 309);
            this.dataGridView1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1166, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // UpdButton
            // 
            this.UpdButton.Font = new System.Drawing.Font("Matura MT Script Capitals", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdButton.Location = new System.Drawing.Point(786, 135);
            this.UpdButton.Name = "UpdButton";
            this.UpdButton.Size = new System.Drawing.Size(284, 59);
            this.UpdButton.TabIndex = 8;
            this.UpdButton.Text = "Update Directory";
            this.UpdButton.UseVisualStyleBackColor = true;
            
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 585);
            this.Controls.Add(this.UpdButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.TBdrivername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBdrivername;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button UpdButton;

        public EventHandler Form1_Load { get; private set; }
    }
}

