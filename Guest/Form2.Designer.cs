namespace Guest
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.btnAddEnter = new System.Windows.Forms.Button();
            this.btnThePrevious = new System.Windows.Forms.Button();
            this.btnTheNext = new System.Windows.Forms.Button();
            this.txtChoice = new System.Windows.Forms.TextBox();
            this.dtgAllChoices = new System.Windows.Forms.DataGridView();
            this.dgtMyChoice = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAllChoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtMyChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(318, 9);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(103, 25);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "שם קטגוריה";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // btnAddDish
            // 
            this.btnAddDish.Location = new System.Drawing.Point(479, 201);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(172, 23);
            this.btnAddDish.TabIndex = 3;
            this.btnAddDish.Text = "הוספת מאכל";
            this.btnAddDish.UseVisualStyleBackColor = true;
            // 
            // btnAddEnter
            // 
            this.btnAddEnter.Location = new System.Drawing.Point(79, 200);
            this.btnAddEnter.Name = "btnAddEnter";
            this.btnAddEnter.Size = new System.Drawing.Size(158, 23);
            this.btnAddEnter.TabIndex = 4;
            this.btnAddEnter.Text = "אישור";
            this.btnAddEnter.UseVisualStyleBackColor = true;
            this.btnAddEnter.Click += new System.EventHandler(this.btnAddEnter_Click);
            // 
            // btnThePrevious
            // 
            this.btnThePrevious.Location = new System.Drawing.Point(479, 460);
            this.btnThePrevious.Name = "btnThePrevious";
            this.btnThePrevious.Size = new System.Drawing.Size(172, 23);
            this.btnThePrevious.TabIndex = 5;
            this.btnThePrevious.Text = "> > >";
            this.btnThePrevious.UseVisualStyleBackColor = true;
            this.btnThePrevious.Click += new System.EventHandler(this.btnThePrevious_Click);
            // 
            // btnTheNext
            // 
            this.btnTheNext.Location = new System.Drawing.Point(79, 460);
            this.btnTheNext.Name = "btnTheNext";
            this.btnTheNext.Size = new System.Drawing.Size(158, 23);
            this.btnTheNext.TabIndex = 6;
            this.btnTheNext.Text = "< < <";
            this.btnTheNext.UseVisualStyleBackColor = true;
            this.btnTheNext.Click += new System.EventHandler(this.btnTheNext_Click);
            // 
            // txtChoice
            // 
            this.txtChoice.Location = new System.Drawing.Point(277, 201);
            this.txtChoice.Name = "txtChoice";
            this.txtChoice.Size = new System.Drawing.Size(166, 22);
            this.txtChoice.TabIndex = 7;
            // 
            // dtgAllChoices
            // 
            this.dtgAllChoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAllChoices.Location = new System.Drawing.Point(79, 48);
            this.dtgAllChoices.Name = "dtgAllChoices";
            this.dtgAllChoices.RowHeadersWidth = 51;
            this.dtgAllChoices.RowTemplate.Height = 24;
            this.dtgAllChoices.Size = new System.Drawing.Size(572, 146);
            this.dtgAllChoices.TabIndex = 8;
            // 
            // dgtMyChoice
            // 
            this.dgtMyChoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtMyChoice.Location = new System.Drawing.Point(79, 287);
            this.dgtMyChoice.Name = "dgtMyChoice";
            this.dgtMyChoice.RowHeadersWidth = 51;
            this.dgtMyChoice.RowTemplate.Height = 24;
            this.dgtMyChoice.Size = new System.Drawing.Size(572, 150);
            this.dgtMyChoice.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = ":הבחירה של כולם ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = ":הבחירה שלך";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgtMyChoice);
            this.Controls.Add(this.dtgAllChoices);
            this.Controls.Add(this.txtChoice);
            this.Controls.Add(this.btnTheNext);
            this.Controls.Add(this.btnThePrevious);
            this.Controls.Add(this.btnAddEnter);
            this.Controls.Add(this.btnAddDish);
            this.Controls.Add(this.lblCategory);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAllChoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtMyChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.Button btnAddEnter;
        private System.Windows.Forms.Button btnThePrevious;
        private System.Windows.Forms.Button btnTheNext;
        private System.Windows.Forms.TextBox txtChoice;
        private System.Windows.Forms.DataGridView dtgAllChoices;
        private System.Windows.Forms.DataGridView dgtMyChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}