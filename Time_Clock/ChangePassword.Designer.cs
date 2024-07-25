namespace Time_Clock
{
    partial class ChangePassword
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
            this.LblOldPassword = new System.Windows.Forms.Label();
            this.LblNewPassword = new System.Windows.Forms.Label();
            this.LblConfNewPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblOldPassword
            // 
            this.LblOldPassword.AutoSize = true;
            this.LblOldPassword.Location = new System.Drawing.Point(494, 124);
            this.LblOldPassword.Name = "LblOldPassword";
            this.LblOldPassword.Size = new System.Drawing.Size(90, 16);
            this.LblOldPassword.TabIndex = 1;
            this.LblOldPassword.Text = "Old password";
            // 
            // LblNewPassword
            // 
            this.LblNewPassword.AutoSize = true;
            this.LblNewPassword.Location = new System.Drawing.Point(494, 207);
            this.LblNewPassword.Name = "LblNewPassword";
            this.LblNewPassword.Size = new System.Drawing.Size(96, 16);
            this.LblNewPassword.TabIndex = 2;
            this.LblNewPassword.Text = "New password";
            // 
            // LblConfNewPassword
            // 
            this.LblConfNewPassword.AutoSize = true;
            this.LblConfNewPassword.Location = new System.Drawing.Point(476, 303);
            this.LblConfNewPassword.Name = "LblConfNewPassword";
            this.LblConfNewPassword.Size = new System.Drawing.Size(141, 16);
            this.LblConfNewPassword.TabIndex = 3;
            this.LblConfNewPassword.Text = "Confirm new password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(251, 297);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(233, 63);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(214, 22);
            this.txtID.TabIndex = 8;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblConfNewPassword);
            this.Controls.Add(this.LblNewPassword);
            this.Controls.Add(this.LblOldPassword);
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblOldPassword;
        private System.Windows.Forms.Label LblNewPassword;
        private System.Windows.Forms.Label LblConfNewPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
    }
}