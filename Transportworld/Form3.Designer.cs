namespace Transportworld
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.BtnDrivers = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dworld1DBDataSet = new Transportworld.Dworld1DBDataSet();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driversTableAdapter = new Transportworld.Dworld1DBDataSetTableAdapters.DriversTableAdapter();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiclesTableAdapter = new Transportworld.Dworld1DBDataSetTableAdapters.VehiclesTableAdapter();
            this.fKVehiclesDriver3E52440BBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dworld1DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btbEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dworld1DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVehiclesDriver3E52440BBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dworld1DBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDrivers
            // 
            this.BtnDrivers.AutoSize = true;
            this.BtnDrivers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDrivers.Location = new System.Drawing.Point(554, 112);
            this.BtnDrivers.Name = "BtnDrivers";
            this.BtnDrivers.Size = new System.Drawing.Size(181, 29);
            this.BtnDrivers.TabIndex = 0;
            this.BtnDrivers.Text = "Update Drivers";
            this.BtnDrivers.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleID,
            this.VehicleType,
            this.RegistrationNumber,
            this.Route});
            this.dataGridView1.Location = new System.Drawing.Point(198, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(987, 426);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // VehicleID
            // 
            this.VehicleID.DataPropertyName = "VehicleID";
            this.VehicleID.HeaderText = "VehicleID";
            this.VehicleID.MinimumWidth = 6;
            this.VehicleID.Name = "VehicleID";
            this.VehicleID.ReadOnly = true;
            this.VehicleID.Width = 125;
            // 
            // VehicleType
            // 
            this.VehicleType.DataPropertyName = "VehicleType";
            this.VehicleType.HeaderText = "VehicleType";
            this.VehicleType.MinimumWidth = 6;
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.Width = 125;
            // 
            // RegistrationNumber
            // 
            this.RegistrationNumber.DataPropertyName = "RegistrationNumber";
            this.RegistrationNumber.HeaderText = "RegistrationNumber";
            this.RegistrationNumber.MinimumWidth = 6;
            this.RegistrationNumber.Name = "RegistrationNumber";
            this.RegistrationNumber.Width = 125;
            // 
            // Route
            // 
            this.Route.DataPropertyName = "Route";
            this.Route.HeaderText = "Route";
            this.Route.MinimumWidth = 6;
            this.Route.Name = "Route";
            this.Route.Width = 125;
            // 
            // dworld1DBDataSet
            // 
            this.dworld1DBDataSet.DataSetName = "Dworld1DBDataSet";
            this.dworld1DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataMember = "Drivers";
            this.driversBindingSource.DataSource = this.dworld1DBDataSet;
            // 
            // driversTableAdapter
            // 
            this.driversTableAdapter.ClearBeforeFill = true;
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "Vehicles";
            this.vehiclesBindingSource.DataSource = this.dworld1DBDataSet;
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // fKVehiclesDriver3E52440BBindingSource
            // 
            this.fKVehiclesDriver3E52440BBindingSource.DataMember = "FK__Vehicles__Driver__3E52440B";
            this.fKVehiclesDriver3E52440BBindingSource.DataSource = this.driversBindingSource;
            // 
            // dworld1DBDataSetBindingSource
            // 
            this.dworld1DBDataSetBindingSource.DataSource = this.dworld1DBDataSet;
            this.dworld1DBDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "TransportWorld";
            // 
            // btbEdit
            // 
            this.btbEdit.FlatAppearance.BorderSize = 7;
            this.btbEdit.Location = new System.Drawing.Point(29, 215);
            this.btbEdit.Name = "btbEdit";
            this.btbEdit.Size = new System.Drawing.Size(120, 52);
            this.btbEdit.TabIndex = 3;
            this.btbEdit.Text = "Update Row";
            this.btbEdit.UseVisualStyleBackColor = true;
            this.btbEdit.Click += new System.EventHandler(this.btbEdit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Edit Driver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btbEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnDrivers);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dworld1DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVehiclesDriver3E52440BBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dworld1DBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BtnDrivers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Dworld1DBDataSet dworld1DBDataSet;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private Dworld1DBDataSetTableAdapters.DriversTableAdapter driversTableAdapter;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private Dworld1DBDataSetTableAdapters.VehiclesTableAdapter vehiclesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Route;
        private System.Windows.Forms.BindingSource fKVehiclesDriver3E52440BBindingSource;
        private System.Windows.Forms.BindingSource dworld1DBDataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btbEdit;
        private System.Windows.Forms.Button button1;
    }
}