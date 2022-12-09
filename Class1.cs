using System;
using System.Collections.Generic;

namespace EmployeeRegApp
{
	

	public class class1
	{
		private static List<Employee> employees = new List<Employee>();

        public static void Main(string[] args)
		{
			Console.WriteLine("Menu");
			string userSelection;
			do
			{
				Console.WriteLine("1. Register Employee\n2. Register Work Hours\n 3.Pay employee\n 0. Exit");
				userSelection=Console.ReadLine();

				switch(userSelection)
				{
					case "0":
						break;
						case "1":
						 RegisterEmployee();
						break;
						case "2":
						RegisterWork();
						break;
						case "3":
						PayEmployee();
						break;
				}
			}while(userSelection!="0");
			Console.WriteLine("You are Exit Successfully!!!");




		}



		private static void RegisterEmployee() 
		{
			Console.WriteLine("Enter Name of Employee:");
			string employeename=Console.ReadLine();
            Console.WriteLine("Enter hourly Rate:");
			string hourlyRate=Console.ReadLine();

			double rate = double.Parse(hourlyRate);

            Employee employee = new Employee(employeename, rate);
            employees.Add(employee);
			Console.WriteLine("Employee Added!!!");

        }
		private static void RegisterWork() 
		{
			Console.WriteLine("Select an employee:");
			for (int i=1; i<=employees.Count; i++)
			{
				Console.WriteLine($"{i}. {employees[i - 1].EmpName}");

			}
			int selection = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter Numbers of Hours Work:");
			int hours = int.Parse(Console.ReadLine());

			Employee selected = employees[selection - 1];
			int workHours = selected.PerformWork(hours);

			Console.Write($"{selected.EmpName}No. of hours worked {workHours}");

		}
		private static void PayEmployee() 
		{
			Console.WriteLine("Select Employee");
			for(int i=1; i<=employees.Count; i++)
			{
				Console.WriteLine($"{employees[i - 1].EmpName}");
			}

			int selection = int.Parse(Console.ReadLine());

			Employee selected= employees[selection - 1];
			int hoorsWorked;
			double receiveWage = selected.receiveWage(out hoorsWorked);

			Console.WriteLine($"{selected.EmpName}={hoorsWorked}{receiveWage}\nThe hours worked is reset to {hoorsWorked}");
		}






    }
}
