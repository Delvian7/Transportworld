namespace Transportworld
{
    partial class Form4
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.textbox3 = new System.Windows.Forms.TextBox();
            this.textbox4 = new System.Windows.Forms.TextBox();
            this.btSav = new System.Windows.Forms.Button();
            this.btCan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textbox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textbox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textbox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textbox4, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(156, 109);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 266);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DriverID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TRN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "License";
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(323, 3);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(256, 22);
            this.textbox1.TabIndex = 4;
            this.textbox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(323, 76);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(250, 22);
            this.textbox2.TabIndex = 5;
            // 
            // textbox3
            // 
            this.textbox3.Location = new System.Drawing.Point(323, 149);
            this.textbox3.Name = "textbox3";
            this.textbox3.Size = new System.Drawing.Size(250, 22);
            this.textbox3.TabIndex = 6;
            // 
            // textbox4
            // 
            this.textbox4.Location = new System.Drawing.Point(323, 225);
            this.textbox4.Name = "textbox4";
            this.textbox4.Size = new System.Drawing.Size(250, 22);
            this.textbox4.TabIndex = 7;
            // 
            // btSav
            // 
            this.btSav.Location = new System.Drawing.Point(191, 382);
            this.btSav.Name = "btSav";
            this.btSav.Size = new System.Drawing.Size(232, 56);
            this.btSav.TabIndex = 1;
            this.btSav.Text = "Save Changes";
            this.btSav.UseVisualStyleBackColor = true;
            this.btSav.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCan
            // 
            this.btCan.Location = new System.Drawing.Point(534, 384);
            this.btCan.Name = "btCan";
            this.btCan.Size = new System.Drawing.Size(195, 52);
            this.btCan.TabIndex = 2;
            this.btCan.Text = "btCancel";
            this.btCan.UseVisualStyleBackColor = true;
            this.btCan.Click += new System.EventHandler(this.btCan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 52);
            this.label5.TabIndex = 3;
            this.label5.Text = "TransportWorld";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(494, 90);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 16);
            this.lblid.TabIndex = 4;
            this.lblid.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btCan);
            this.Controls.Add(this.btSav);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btSav;
        private System.Windows.Forms.Button btCan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.TextBox textbox3;
        private System.Windows.Forms.TextBox textbox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblid;
    }
}