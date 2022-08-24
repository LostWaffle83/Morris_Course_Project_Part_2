namespace Morris_Course_Project_Part_2
{
    partial class InputForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.hireDateLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.hireDateTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BenefitsGroupBox = new System.Windows.Forms.GroupBox();
            this.VacationDaysTextBox = new System.Windows.Forms.TextBox();
            this.LifeInsTextBox = new System.Windows.Forms.TextBox();
            this.HealthInsTextBox = new System.Windows.Forms.TextBox();
            this.vacationLabel = new System.Windows.Forms.Label();
            this.lifeInsLabel = new System.Windows.Forms.Label();
            this.healthInsLabel = new System.Windows.Forms.Label();
            this.HourlyRadioButton = new System.Windows.Forms.RadioButton();
            this.SalaryRadioButton = new System.Windows.Forms.RadioButton();
            this.Pay1TextBox = new System.Windows.Forms.TextBox();
            this.Pay1Label = new System.Windows.Forms.Label();
            this.Pay2TextBox = new System.Windows.Forms.TextBox();
            this.Pay2Label = new System.Windows.Forms.Label();
            this.BenefitsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.Location = new System.Drawing.Point(60, 67);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(117, 24);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.Location = new System.Drawing.Point(60, 114);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(115, 24);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ssnLabel.Location = new System.Drawing.Point(119, 160);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(56, 24);
            this.ssnLabel.TabIndex = 2;
            this.ssnLabel.Text = "SSN:";
            // 
            // hireDateLabel
            // 
            this.hireDateLabel.AutoSize = true;
            this.hireDateLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hireDateLabel.Location = new System.Drawing.Point(71, 205);
            this.hireDateLabel.Name = "hireDateLabel";
            this.hireDateLabel.Size = new System.Drawing.Size(104, 24);
            this.hireDateLabel.TabIndex = 3;
            this.hireDateLabel.Text = "Hire Date:";
            this.hireDateLabel.Click += new System.EventHandler(this.hireDateLabel_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameTextBox.Location = new System.Drawing.Point(183, 71);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(263, 26);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameTextBox.Location = new System.Drawing.Point(183, 118);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(263, 26);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ssnTextBox.Location = new System.Drawing.Point(183, 164);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(263, 26);
            this.ssnTextBox.TabIndex = 3;
            // 
            // hireDateTextBox
            // 
            this.hireDateTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hireDateTextBox.Location = new System.Drawing.Point(183, 209);
            this.hireDateTextBox.Name = "hireDateTextBox";
            this.hireDateTextBox.Size = new System.Drawing.Size(263, 26);
            this.hireDateTextBox.TabIndex = 4;
            this.hireDateTextBox.TextChanged += new System.EventHandler(this.hireDateTextBox_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SubmitButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubmitButton.Location = new System.Drawing.Point(60, 529);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(168, 93);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(278, 529);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(168, 93);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BenefitsGroupBox
            // 
            this.BenefitsGroupBox.Controls.Add(this.VacationDaysTextBox);
            this.BenefitsGroupBox.Controls.Add(this.LifeInsTextBox);
            this.BenefitsGroupBox.Controls.Add(this.HealthInsTextBox);
            this.BenefitsGroupBox.Controls.Add(this.vacationLabel);
            this.BenefitsGroupBox.Controls.Add(this.lifeInsLabel);
            this.BenefitsGroupBox.Controls.Add(this.healthInsLabel);
            this.BenefitsGroupBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BenefitsGroupBox.Location = new System.Drawing.Point(20, 331);
            this.BenefitsGroupBox.Name = "BenefitsGroupBox";
            this.BenefitsGroupBox.Size = new System.Drawing.Size(445, 179);
            this.BenefitsGroupBox.TabIndex = 7;
            this.BenefitsGroupBox.TabStop = false;
            this.BenefitsGroupBox.Text = "Benefits";
            // 
            // VacationDaysTextBox
            // 
            this.VacationDaysTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VacationDaysTextBox.Location = new System.Drawing.Point(168, 138);
            this.VacationDaysTextBox.Name = "VacationDaysTextBox";
            this.VacationDaysTextBox.Size = new System.Drawing.Size(263, 26);
            this.VacationDaysTextBox.TabIndex = 9;
            // 
            // LifeInsTextBox
            // 
            this.LifeInsTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LifeInsTextBox.Location = new System.Drawing.Point(168, 92);
            this.LifeInsTextBox.Name = "LifeInsTextBox";
            this.LifeInsTextBox.Size = new System.Drawing.Size(263, 26);
            this.LifeInsTextBox.TabIndex = 6;
            // 
            // HealthInsTextBox
            // 
            this.HealthInsTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HealthInsTextBox.Location = new System.Drawing.Point(168, 45);
            this.HealthInsTextBox.Name = "HealthInsTextBox";
            this.HealthInsTextBox.Size = new System.Drawing.Size(263, 26);
            this.HealthInsTextBox.TabIndex = 4;
            // 
            // vacationLabel
            // 
            this.vacationLabel.AutoSize = true;
            this.vacationLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vacationLabel.Location = new System.Drawing.Point(12, 137);
            this.vacationLabel.Name = "vacationLabel";
            this.vacationLabel.Size = new System.Drawing.Size(145, 24);
            this.vacationLabel.TabIndex = 8;
            this.vacationLabel.Text = "Vacation Days:";
            // 
            // lifeInsLabel
            // 
            this.lifeInsLabel.AutoSize = true;
            this.lifeInsLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lifeInsLabel.Location = new System.Drawing.Point(24, 91);
            this.lifeInsLabel.Name = "lifeInsLabel";
            this.lifeInsLabel.Size = new System.Drawing.Size(145, 24);
            this.lifeInsLabel.TabIndex = 7;
            this.lifeInsLabel.Text = "Life Insurance:";
            // 
            // healthInsLabel
            // 
            this.healthInsLabel.AutoSize = true;
            this.healthInsLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.healthInsLabel.Location = new System.Drawing.Point(0, 47);
            this.healthInsLabel.Name = "healthInsLabel";
            this.healthInsLabel.Size = new System.Drawing.Size(169, 24);
            this.healthInsLabel.TabIndex = 5;
            this.healthInsLabel.Text = "Health Insurance:";
            // 
            // HourlyRadioButton
            // 
            this.HourlyRadioButton.AutoSize = true;
            this.HourlyRadioButton.Checked = true;
            this.HourlyRadioButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HourlyRadioButton.Location = new System.Drawing.Point(57, 28);
            this.HourlyRadioButton.Name = "HourlyRadioButton";
            this.HourlyRadioButton.Size = new System.Drawing.Size(89, 28);
            this.HourlyRadioButton.TabIndex = 8;
            this.HourlyRadioButton.TabStop = true;
            this.HourlyRadioButton.Text = "Hourly";
            this.HourlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // SalaryRadioButton
            // 
            this.SalaryRadioButton.AutoSize = true;
            this.SalaryRadioButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SalaryRadioButton.Location = new System.Drawing.Point(343, 28);
            this.SalaryRadioButton.Name = "SalaryRadioButton";
            this.SalaryRadioButton.Size = new System.Drawing.Size(85, 28);
            this.SalaryRadioButton.TabIndex = 9;
            this.SalaryRadioButton.TabStop = true;
            this.SalaryRadioButton.Text = "Salary";
            this.SalaryRadioButton.UseVisualStyleBackColor = true;
            // 
            // Pay1TextBox
            // 
            this.Pay1TextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pay1TextBox.Location = new System.Drawing.Point(188, 251);
            this.Pay1TextBox.Name = "Pay1TextBox";
            this.Pay1TextBox.Size = new System.Drawing.Size(263, 26);
            this.Pay1TextBox.TabIndex = 11;
            // 
            // Pay1Label
            // 
            this.Pay1Label.AutoSize = true;
            this.Pay1Label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pay1Label.Location = new System.Drawing.Point(34, 250);
            this.Pay1Label.Name = "Pay1Label";
            this.Pay1Label.Size = new System.Drawing.Size(126, 24);
            this.Pay1Label.TabIndex = 10;
            this.Pay1Label.Text = "Hourly Rate:";
            // 
            // Pay2TextBox
            // 
            this.Pay2TextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pay2TextBox.Location = new System.Drawing.Point(188, 288);
            this.Pay2TextBox.Name = "Pay2TextBox";
            this.Pay2TextBox.Size = new System.Drawing.Size(263, 26);
            this.Pay2TextBox.TabIndex = 13;
            // 
            // Pay2Label
            // 
            this.Pay2Label.AutoSize = true;
            this.Pay2Label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pay2Label.Location = new System.Drawing.Point(29, 287);
            this.Pay2Label.Name = "Pay2Label";
            this.Pay2Label.Size = new System.Drawing.Size(146, 24);
            this.Pay2Label.TabIndex = 12;
            this.Pay2Label.Text = "Hours Worked:";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 641);
            this.Controls.Add(this.Pay2TextBox);
            this.Controls.Add(this.Pay2Label);
            this.Controls.Add(this.Pay1TextBox);
            this.Controls.Add(this.Pay1Label);
            this.Controls.Add(this.SalaryRadioButton);
            this.Controls.Add(this.HourlyRadioButton);
            this.Controls.Add(this.BenefitsGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.hireDateTextBox);
            this.Controls.Add(this.ssnTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.hireDateLabel);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "InputForm";
            this.Text = "Employee Input Form";
            this.BenefitsGroupBox.ResumeLayout(false);
            this.BenefitsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label ssnLabel;
        private Label hireDateLabel;
        private Button ExitButton;
        public TextBox firstNameTextBox;
        public TextBox lastNameTextBox;
        public TextBox ssnTextBox;
        public TextBox hireDateTextBox;
        private GroupBox BenefitsGroupBox;
        public TextBox VacationDaysTextBox;
        public TextBox LifeInsTextBox;
        public TextBox HealthInsTextBox;
        private Label vacationLabel;
        private Label lifeInsLabel;
        private Label healthInsLabel;
        public Button SubmitButton;
        private RadioButton HourlyRadioButton;
        private RadioButton SalaryRadioButton;
        public TextBox Pay1TextBox;
        private Label Pay1Label;
        public TextBox Pay2TextBox;
        private Label Pay2Label;
    }
}