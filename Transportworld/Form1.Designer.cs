﻿namespace Transportworld
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
            this.label3 = new System.Windows.Forms.Label();
            this.TbTrn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "TransportWorld";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Driver Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TBdrivername
            // 
            this.TBdrivername.Location = new System.Drawing.Point(77, 159);
            this.TBdrivername.Name = "TBdrivername";
            this.TBdrivername.Size = new System.Drawing.Size(224, 22);
            this.TBdrivername.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(493, 159);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(116, 97);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "TRN";
            // 
            // TbTrn
            // 
            this.TbTrn.Location = new System.Drawing.Point(77, 234);
            this.TbTrn.Name = "TbTrn";
            this.TbTrn.Size = new System.Drawing.Size(224, 22);
            this.TbTrn.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbTrn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.TBdrivername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBdrivername;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbTrn;
    }
}

