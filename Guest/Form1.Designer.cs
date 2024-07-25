namespace Guest
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
            this.LblWelcome = new System.Windows.Forms.Label();
            this.LblGuests = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lsbAllGuests = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcome.Location = new System.Drawing.Point(266, 31);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(211, 38);
            this.LblWelcome.TabIndex = 0;
            this.LblWelcome.Text = "ברוכים הבאים";
            // 
            // LblGuests
            // 
            this.LblGuests.AutoSize = true;
            this.LblGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGuests.Location = new System.Drawing.Point(306, 91);
            this.LblGuests.Name = "LblGuests";
            this.LblGuests.Size = new System.Drawing.Size(120, 25);
            this.LblGuests.TabIndex = 1;
            this.LblGuests.Text = "הכנס שם אורח";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(228, 364);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(117, 36);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "אישור";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(311, 133);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 3;
            // 
            // lsbAllGuests
            // 
            this.lsbAllGuests.FormattingEnabled = true;
            this.lsbAllGuests.ItemHeight = 16;
            this.lsbAllGuests.Location = new System.Drawing.Point(228, 175);
            this.lsbAllGuests.Name = "lsbAllGuests";
            this.lsbAllGuests.Size = new System.Drawing.Size(292, 148);
            this.lsbAllGuests.TabIndex = 4;
            this.lsbAllGuests.SelectedIndexChanged += new System.EventHandler(this.lsbAllGuests_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(416, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "מחק";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsbAllGuests);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.LblGuests);
            this.Controls.Add(this.LblWelcome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.Label LblGuests;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ListBox lsbAllGuests;
        private System.Windows.Forms.Button button1;
    }
}

