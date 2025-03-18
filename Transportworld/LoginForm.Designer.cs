namespace Transportworld
{
    partial class LoginForm
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
            this.TBusername = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(338, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBusername
            // 
            this.TBusername.Location = new System.Drawing.Point(232, 167);
            this.TBusername.Name = "TBusername";
            this.TBusername.Size = new System.Drawing.Size(336, 22);
            this.TBusername.TabIndex = 1;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(232, 254);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(336, 22);
            this.TBPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(338, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // BtLogin
            // 
            this.BtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLogin.Location = new System.Drawing.Point(307, 302);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.Size = new System.Drawing.Size(161, 79);
            this.BtLogin.TabIndex = 4;
            this.BtLogin.Text = "Login";
            this.BtLogin.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.BtLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBusername);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBusername;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtLogin;
    }
}