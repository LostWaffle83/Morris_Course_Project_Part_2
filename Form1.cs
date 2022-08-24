using System;
using System.IO;
using System.Windows.Forms;

namespace Morris_Course_Project_Part_2
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Add item to Employee List Box
            InputForm frmInput = new InputForm();

            using (frmInput)
            {
                DialogResult result = frmInput.ShowDialog();

                // See if input was cancelled
                if (result == DialogResult.Cancel)
                    return; // End the method since the user cancelled the input

                // Get the user's input and create an Employee obcject
                string fName = frmInput.firstNameTextBox.Text;
                string lName = frmInput.lastNameTextBox.Text;
                string ssn = frmInput.ssnTextBox.Text;
                string date = frmInput.hireDateTextBox.Text;
                DateTime hireDate = DateTime.Parse(date);
                string heatlhIns = frmInput.HealthInsTextBox.Text;
                double lifeIns = Double.Parse(frmInput.LifeInsTextBox.Text);
                int vacation = Int32.Parse(frmInput.VacationDaysTextBox.Text);

                Benefits benefits = new Benefits(heatlhIns, lifeIns, vacation);
                Employee emp = new Employee(fName, lName, ssn, hireDate, benefits);

                // Add the new Employee to the Employee List Box
                EmployeeListBox.Items.Add(emp);

                // Write Employee to file
                WriteEmpsToFile();
            }
        }

        private void WriteEmpsToFile()
        {
            // Write Employee data to file
            string fileName = "Employees.csv";
            StreamWriter sw = new StreamWriter(fileName);
            for (int i = 0; i < EmployeeListBox.Items.Count; i++)
            {
                Employee temp = (Employee)EmployeeListBox.Items[i];

                sw.WriteLine(temp.FirstName + ',' + temp.LastName + ',' + temp.SSN + ',' +
                    temp.HireDate.ToShortDateString() + ',' +
                    temp.BenefitsPackage.HealthInsurance + ',' +
                    temp.BenefitsPackage.LifeInsurance + ',' + temp.BenefitsPackage.Vacation);
            }
            sw.Close();

            // Informs users that Employee data was added
            MessageBox.Show("Employee information sucessfully updated.");
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // Remove item from Employee List Box
            int itemNumber = EmployeeListBox.SelectedIndex;

            if (itemNumber > -1)
            {
                EmployeeListBox.Items.RemoveAt(itemNumber);

                // Write Employee to file
                WriteEmpsToFile();
            }
            else
            {
                MessageBox.Show("Please select employee to remove.");
            }

            // Write Employee to file
            WriteEmpsToFile();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            // Clear the listbox
            EmployeeListBox.Items.Clear();

            // Read all employee objects from the file
            ReadEmpsFromFile();
        }

        private void ReadEmpsFromFile()
        {
            // Read all employee objects from the file
            string fileName = "Employees.csv";

            StreamReader sr = new StreamReader(fileName);
            using (sr)
            {

                while (sr.Peek() > -1)
                {
                    // Read the line and break into parts based upon the commas
                    string line = sr.ReadLine();
                    string[] parts = line.Split(',');

                    string fName = parts[0];
                    string lName = parts[1];
                    string ssn = parts[2];
                    DateTime hireDate = DateTime.Parse(parts[3]);
                    string healthIns = parts[4];
                    double lifeIns = Double.Parse(parts[5]);
                    int vacation = Int32.Parse(parts[6]);

                    // Create employee object and add it to the list box
                    Employee emp = new Employee(fName, lName, ssn, hireDate,
                        new Benefits(healthIns, lifeIns, vacation));
                    EmployeeListBox.Items.Add(emp);
                }
            }
        }

        private void PrintPaychecksButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing all paychecks...");
        }

        private void From1_Load(object sender, EventArgs e)
        {
            // Load the Employee data from file
            ReadEmpsFromFile();
        }

        private void EmployeeListBox_DoubleClick(object sender, EventArgs e)
        {
            // Edit selected employee in the listbox
            InputForm frmUpdate = new InputForm();

            using (frmUpdate)
            {
                frmUpdate.Text = "Employee Update Form";
                frmUpdate.SubmitButton.Text = "Update";

                int itemNumber = EmployeeListBox.SelectedIndex;

                if (itemNumber < 0)
                {
                    MessageBox.Show("Error. Invalid Employee.");
                    return;
                }

                Employee emp = (Employee)EmployeeListBox.Items[itemNumber];

                frmUpdate.firstNameTextBox.Text = emp.FirstName;
                frmUpdate.lastNameTextBox.Text = emp.LastName;
                frmUpdate.ssnTextBox.Text = emp.SSN;
                frmUpdate.hireDateTextBox.Text = emp.HireDate.ToShortDateString();
                frmUpdate.HealthInsTextBox.Text = emp.BenefitsPackage.HealthInsurance;
                frmUpdate.LifeInsTextBox.Text = emp.BenefitsPackage.LifeInsurance.ToString("C2");
                frmUpdate.VacationDaysTextBox.Text = emp.BenefitsPackage.Vacation.ToString();

                DialogResult result = frmUpdate.ShowDialog();

                if (result == DialogResult.Cancel)
                    return; // End the method since user cancelled  the update

                EmployeeListBox.Items.RemoveAt(itemNumber);

                // Get user's updated input and create an Employee object
                string fName = frmUpdate.firstNameTextBox.Text;
                string lName = frmUpdate.lastNameTextBox.Text;
                string ssn = frmUpdate.ssnTextBox.Text;
                string date = frmUpdate.hireDateTextBox.Text;
                DateTime hireDate = DateTime.Parse(date);
                string healthIns = frmUpdate.HealthInsTextBox.Text;
                // pull a substring that does not contain the intial '$' sign
                string lifeInsString = frmUpdate.LifeInsTextBox.Text;
                lifeInsString = lifeInsString.Substring(1);
                double lifeIns = Double.Parse(lifeInsString);
                int vacationDays = Int32.Parse(frmUpdate.VacationDaysTextBox.Text);

                Benefits benefits = new Benefits(healthIns, lifeIns, vacationDays);
                emp = new Employee(fName, lName, ssn, hireDate, benefits);

                // Add the updated Employee object to the employess listbox
                EmployeeListBox.Items.Add(emp);

                // Write all of the updated Employee objects to the file
                WriteEmpsToFile();

            }
        }

    }
}