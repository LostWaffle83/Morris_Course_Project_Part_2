using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morris_Course_Project_Part_2
{
    internal class Employee
    {
        // Attributes
        protected string firstName;
        protected string lastName;
        protected string ssn;
        protected DateTime hireDate;
        protected Benefits benefits;

        // Constructors
        public Employee()
        {
            firstName = "Unkown";
            lastName = "Unkown";
            ssn = "Unkown";
            hireDate = DateTime.MinValue;
        }

        public Employee (string firstName, string lastName, string snn, DateTime hireDate, Benefits benefits)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SSN = snn;
            this.HireDate = hireDate;
            this.BenefitsPackage = benefits;
        }

        // Behaviors
        public override string ToString()
        {
            // Jack Jones, SSN: 555-55-5555, Hire Date: XX/XX/XXXX
            return firstName + " " + lastName + ", SSN: " + ssn + ",Hire Date: " + hireDate.ToShortDateString();
        }

        public virtual double CalculatePay()
        {
            return 0.0;
        }

        // Properties
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length > 0)
                    firstName = value;
                else
                    firstName = "unknown";
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length > 0)
                    lastName = value;
                else
                    lastName = "unknown";
            }
        }

        public string SSN
        {
            get
            {
                return ssn;
            }
            set
            {
                if (value.Length == 9 || value.Length == 11)
                    ssn = value;
                else
                    ssn = "unknown";
            }
        }

        public DateTime HireDate
        {
            get
            {
                return hireDate;
            }
            set
            {
                if (value.Year > 1960 && value.Year < DateTime.Now.Year + 1)
                    hireDate = value;
                else
                    hireDate = DateTime.MinValue; // 01/01/0001
            }
        }

        public Benefits BenefitsPackage
        {
            get
            {
                return benefits;
            }
            set
            {
                this.benefits = value;
            }
        }
    }
}
