namespace Morris_Course_Project_Part_2
{
    partial class From1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.PrintPaychecksButton = new System.Windows.Forms.Button();
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(12, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(132, 79);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveButton.Location = new System.Drawing.Point(12, 109);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(132, 79);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DisplayButton.Location = new System.Drawing.Point(12, 209);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(132, 79);
            this.DisplayButton.TabIndex = 2;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // PrintPaychecksButton
            // 
            this.PrintPaychecksButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrintPaychecksButton.Location = new System.Drawing.Point(12, 311);
            this.PrintPaychecksButton.Name = "PrintPaychecksButton";
            this.PrintPaychecksButton.Size = new System.Drawing.Size(132, 79);
            this.PrintPaychecksButton.TabIndex = 3;
            this.PrintPaychecksButton.Text = "Print Paychecks";
            this.PrintPaychecksButton.UseVisualStyleBackColor = true;
            this.PrintPaychecksButton.Click += new System.EventHandler(this.PrintPaychecksButton_Click);
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeListBox.FormattingEnabled = true;
            this.EmployeeListBox.ItemHeight = 21;
            this.EmployeeListBox.Location = new System.Drawing.Point(207, 12);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.Size = new System.Drawing.Size(581, 361);
            this.EmployeeListBox.TabIndex = 4;
            this.EmployeeListBox.DoubleClick += new System.EventHandler(this.EmployeeListBox_DoubleClick);
            // 
            // From1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 448);
            this.Controls.Add(this.EmployeeListBox);
            this.Controls.Add(this.PrintPaychecksButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Name = "From1";
            this.Text = "Employee Payroll";
            this.Load += new System.EventHandler(this.From1_Load);
            this.ResumeLayout(true);

        }

        #endregion

        private Button AddButton;
        private Button RemoveButton;
        private Button DisplayButton;
        private Button PrintPaychecksButton;
        private ListBox EmployeeListBox;
    }
}