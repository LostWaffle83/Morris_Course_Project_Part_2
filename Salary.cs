using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morris_Course_Project_Part_2
{
    internal class Salary : Employee
    {
        // Attribute
        private double annualSalary;

        // Constructors
        public Salary() : base()
        {
            annualSalary = 0.0;
        }

        public Salary(string firstName, string lastName, string ssn, 
            DateTime hireDate, Benefits benefits, double annualSalary) 
            : base(firstName, lastName, ssn, hireDate, benefits)
        {
            AnnualSalary = annualSalary;
        }
        // Behaviors
        public override string ToString()
        {
            return base.ToString() + ", Salary: " + annualSalary.ToString("C");
        }

        public override double CalculatePay()
        {
            return annualSalary / 26.0;
        }
        // Properties
        public double AnnualSalary
        {
            get
            { 
                return annualSalary; 
            }
            set
            {
                if (value > 0.0 && value < 1000000.0)
                    annualSalary = value;
                else
                    annualSalary = value;
            }
        }
    }
}
