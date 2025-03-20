namespace Transportworld
{
    partial class Form2
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btdelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btedit = new System.Windows.Forms.Button();
            this.btcreate = new System.Windows.Forms.Button();
            this.Btsee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "TransportWorld";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(792, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(320, 28);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(111, 459);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(130, 49);
            this.btdelete.TabIndex = 2;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 296);
            this.dataGridView1.TabIndex = 3;
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(111, 382);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(130, 49);
            this.btedit.TabIndex = 4;
            this.btedit.Text = "Edit";
            this.btedit.UseVisualStyleBackColor = true;
            // 
            // btcreate
            // 
            this.btcreate.Location = new System.Drawing.Point(111, 293);
            this.btcreate.Name = "btcreate";
            this.btcreate.Size = new System.Drawing.Size(130, 49);
            this.btcreate.TabIndex = 5;
            this.btcreate.Text = "Create";
            this.btcreate.UseVisualStyleBackColor = true;
            // 
            // Btsee
            // 
            this.Btsee.Location = new System.Drawing.Point(111, 128);
            this.Btsee.Name = "Btsee";
            this.Btsee.Size = new System.Drawing.Size(130, 49);
            this.Btsee.TabIndex = 6;
            this.Btsee.Text = "See All";
            this.Btsee.UseVisualStyleBackColor = true;
            this.Btsee.Click += new System.EventHandler(this.Btsee_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 583);
            this.Controls.Add(this.Btsee);
            this.Controls.Add(this.btcreate);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Manage Drivers listing";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btcreate;
        private System.Windows.Forms.Button Btsee;
    }
}