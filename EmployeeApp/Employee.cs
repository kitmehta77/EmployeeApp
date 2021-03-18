using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        protected int employeeID;
        protected string lastName;
        protected string firstName;
        protected double hourlyRate;
        protected int hours;



        public Employee(int newEmployeeID, string newLastName, string newFirstName,
                        double newHourlyRate, int newHours)
        {
            employeeID = newEmployeeID;
            lastName = newLastName;
            firstName = newFirstName;
            hourlyRate = newHourlyRate;
            hours = newHours;
        }

        public int getEmployeeID()
        {
            return employeeID;
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getFirstName()
        {
            return firstName;
        }
        public double getHourlyRate()
        {
            return hourlyRate;
        }

        public int getHours()
        {
            return hours;
        }

        public void setLastName(string newLastName)
        {
            lastName = newLastName;
        }

        public void setFirstName(string newFirstName)
        {
            firstName = newFirstName;

        }

        public void setHourlyRate(double newHourlyRate)
        {
            hourlyRate = newHourlyRate;
        }

        public void setHours(int newHours)
        {
            hours = newHours;
        }


        public override string ToString()
        {
            return lastName + ", " + firstName + "  (" + hourlyRate.ToString() + ")";
        }


        public string Show()
        {
            return ("ID: " + employeeID.ToString()
                + " Name: " + firstName + " " + lastName
                + "  HourlyRate: " + hourlyRate.ToString()
                + "  Hours: " + hours.ToString());
        }

        public string CommaText()
        {
            return (employeeID.ToString() + "," + lastName + "," + firstName
                + "," + hourlyRate.ToString()
                + "," + hours.ToString());
        }

    }
}
