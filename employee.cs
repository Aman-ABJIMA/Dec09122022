using System;
namespace EmployeeRegApp
{
    class Employee
    {
        private string empName;
        private int workHours;
        private double wage;
        private double hourlyRate;

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

        public int WorkHours
        {
            get { return workHours; }
            set { workHours = value; }
        }
        public double Wage
        {
            get { 
                return wage; }
            set { 
                wage = value; 
            }
        }
        public double HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }


        //Construtor

        public Employee(string name, double rate)
        {
            EmpName = name;
            HourlyRate = rate;
        }

        public int PerformWork(int hours)
        {
            WorkHours += hours;
            return WorkHours;
        }

        public double receiveWage(out int hoursWorked)
        {
            Wage = WorkHours * HourlyRate;
            Console.WriteLine($"The Wage for {WorkHours} hours of work is :{Wage}");
            WorkHours = 0;
            hoursWorked = WorkHours;
            return Wage;
        }
    





    }
}