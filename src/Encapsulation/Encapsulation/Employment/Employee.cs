using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Employment
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private double _monthlySalary;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = string.IsNullOrEmpty(value) ? "Unknown" : value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = string.IsNullOrEmpty(value) ? "Unknown" : value; }
        }

        public double MonthlySalary
        {
            get { return _monthlySalary; }
            set { if (value > 0) _monthlySalary = value; }
        }

        public Employee(string firstName, string lastName, double monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary > 0 ? monthlySalary : 0;
        }

        public void RaiseSalary(int raisePercentage)
        {
            if (raisePercentage > 0 && raisePercentage <= 20)
            {
                MonthlySalary += MonthlySalary * raisePercentage / 100;
            }
        }

        public double GetYearlySalary()
        {
            return MonthlySalary * 12;
        }
    }

}

