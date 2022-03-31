using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10.Models
{
    class Employee:Person
    {
        private double _workingHour;
        public double WorkingHour
        {
            get 
            {
                return _workingHour;
            }
            set 
            {
                if (value < 240)
                {
                    _workingHour = value;
                }
                else Console.WriteLine("Isci gunde 8 saatdan cox isleye bilmez");
            } 
        }
        private double _salaryOfHour;
        public double SalaryOfHour
        {
            get
            {
                return _salaryOfHour;
            }
            set
            {
                if (value* _workingHour > 250 )
                {
                    _salaryOfHour = value;
                }
                else Console.WriteLine("Maas 250den cox olmalidir");
            }
        }
        public double CalculateSalary()
        {
            double calculatesalary = SalaryOfHour * WorkingHour;
            return calculatesalary;
        }
        public Employee(string name, string surname, int age, double salaryofhour, double workinghour)
        {
            Name = name;
            Surname = surname;
            Age = age;
            if (age < 18)
            {
                Console.WriteLine("Islemek huququ yoxdur");
            }
            WorkingHour = workinghour;
            SalaryOfHour = salaryofhour;
        }

    }
}
