namespace Host
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
            this.lblCategoryHost = new System.Windows.Forms.Label();
            this.btnCategoryEnter = new System.Windows.Forms.Button();
            this.txtCategorySelection = new System.Windows.Forms.TextBox();
            this.lsbCategory = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCategoryHost
            // 
            this.lblCategoryHost.AutoSize = true;
            this.lblCategoryHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryHost.Location = new System.Drawing.Point(285, 38);
            this.lblCategoryHost.Name = "lblCategoryHost";
            this.lblCategoryHost.Size = new System.Drawing.Size(206, 38);
            this.lblCategoryHost.TabIndex = 0;
            this.lblCategoryHost.Text = "הכנס קטגוריה";
            // 
            // btnCategoryEnter
            // 
            this.btnCategoryEnter.Location = new System.Drawing.Point(292, 159);
            this.btnCategoryEnter.Name = "btnCategoryEnter";
            this.btnCategoryEnter.Size = new System.Drawing.Size(85, 61);
            this.btnCategoryEnter.TabIndex = 1;
            this.btnCategoryEnter.Text = "מחק";
            this.btnCategoryEnter.UseVisualStyleBackColor = true;
            this.btnCategoryEnter.Click += new System.EventHandler(this.btnCategoryEnter_Click);
            // 
            // txtCategorySelection
            // 
            this.txtCategorySelection.Location = new System.Drawing.Point(292, 107);
            this.txtCategorySelection.Name = "txtCategorySelection";
            this.txtCategorySelection.Size = new System.Drawing.Size(201, 22);
            this.txtCategorySelection.TabIndex = 2;
            this.txtCategorySelection.TextChanged += new System.EventHandler(this.txtCategorySelection_TextChanged_1);
            // 
            // lsbCategory
            // 
            this.lsbCategory.FormattingEnabled = true;
            this.lsbCategory.ItemHeight = 16;
            this.lsbCategory.Location = new System.Drawing.Point(292, 255);
            this.lsbCategory.Name = "lsbCategory";
            this.lsbCategory.Size = new System.Drawing.Size(201, 180);
            this.lsbCategory.TabIndex = 3;
            this.lsbCategory.SelectedIndexChanged += new System.EventHandler(this.lsbCategory_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "הכנס";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 90);
            this.button2.TabIndex = 5;
            this.button2.Text = "צפיה בהזמנה";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 660);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsbCategory);
            this.Controls.Add(this.txtCategorySelection);
            this.Controls.Add(this.btnCategoryEnter);
            this.Controls.Add(this.lblCategoryHost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryHost;
        private System.Windows.Forms.Button btnCategoryEnter;
        private System.Windows.Forms.TextBox txtCategorySelection;
        private System.Windows.Forms.ListBox lsbCategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

