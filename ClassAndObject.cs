using System;
namespace Class_of_Employee
{
    class Employee
    {              
        //Members
        public string employee_name;
        public int employee_id;
        public long employee_number;
       
        public int monthlyWage = 12000;

        public int months = 12;

        public int bonus = 300;

        //Methods
     
     //1 Constructor
        public Employee()   
        {
            Console.WriteLine("Enter Employee Full Name:");
            employee_name = Console.ReadLine();
            Console.WriteLine("Enter Employee ID:");
            employee_id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter MOB. NO:");
            employee_number= Convert.ToInt64(Console.ReadLine());
            Console.Clear();
        }

     //2
        public void Processing()
        {

            int yearlyWageEmployee = Calculate(monthlyWage, months, bonus); //function Calling by Value
           
            Console.WriteLine("YEARLY WAGE OF EMPLOYEE:" + yearlyWageEmployee + "\n"); 
        }
        static int Calculate(int mw, int m, int b)
        {
            if (mw < 2000)
                b = b * 2;

            Console.WriteLine("The Employee got bonus:" + b);
            Console.WriteLine($"Yearly Wage = {mw}*{m}+{b}");
            return (mw * m + b);
        }



        //3 
        public void Display()=>
        
           
            Console.WriteLine($"Employee ID:{employee_id}\nEmployee Name:{employee_name}\nEmployee_Number:{employee_number}");

     
        //Main Method
        public static void Main(string[] args)
        {


            Employee obj = new Employee();

            obj.Display();

            obj.Processing();
        
        }

    }
}