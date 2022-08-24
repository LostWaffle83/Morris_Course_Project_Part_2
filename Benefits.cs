using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morris_Course_Project_Part_2
{
    internal class Benefits
    {
        // Attributes
        private string healthInsurance;
        private double lifeInsurance;
        private int vacation;

        // Constructors
        public Benefits()
        {
            healthInsurance = "Unknown";
            lifeInsurance = 0.0;
            vacation = 0;
        }

        public Benefits(string healthInsurance, double lifeInsurance, int vacation)
        {
            HealthInsurance = healthInsurance;
            LifeInsurance = lifeInsurance;
            Vacation = vacation;
        }

        // Behaviors
        public override string ToString()
        {
            return "Health Insurance: " + healthInsurance + ", Life Insurance: " + lifeInsurance 
                + ", Vacation Days: " + vacation;
        }
        // Properties (get/set methods)
        public string HealthInsurance
        {
            get
            {
                return healthInsurance;
            }
            set
            {
                if (value.Length > 0)
                    healthInsurance = value;
                else
                    healthInsurance = "Unknown";
            }
        }

        public double LifeInsurance
        {
            get
            {
                return lifeInsurance;
            }
            set
            {
                if (value > 0.0 && value <= 10000000.0)
                    lifeInsurance = value;
                else
                    lifeInsurance = 0.0;
            }
        }

        public int Vacation
        {
            get
            {
                return vacation;
            }
            set
            {
                if (value > 0 && value <= 40)
                    vacation = value;
                else
                    vacation = 0;
            }
        }
    }
}
