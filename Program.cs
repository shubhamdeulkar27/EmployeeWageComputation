using System;

namespace EmployeeWageComputation
{
    class Program
    {
        //CONSTANTS
        private const int IS_PART_TIME = 1;
        private const int IS_FULL_TIME = 2;
        private const int WAGE_PER_HOUR = 20;
        private const int MAX_WORKING_DAYS = 20;
        private const int MAX_WORKING_HOURS = 100;

        //FUNCTION TO CHECK EMPLOYEE ATTENDENCE RANDOMLY
        public int checkEmployee()
        {
            Random random = new Random();
            int randomCheck = random.Next(3);
            return randomCheck;
        }
        //FUNCTION TO CHECK EMPLOYEE WORKING HOURS
        public int checkEmployeeHour(int employeeAttendenceCheck) 
        {
            int employeeHours = 0;
            switch (employeeAttendenceCheck)
            {
                case IS_FULL_TIME:
                    employeeHours = 8;
                    break;
                case IS_PART_TIME:
                    employeeHours = 4;
                    break;
                default:
                    employeeHours = 0;
                    break;
            }
            return employeeHours;
        }

        //FUNCTION FOR CALCULATING MONTHLY WAGES
        public int[] calculateWageForMonth(int MAX_WORKING_DAYS) 
        {
            //VARIABLE
            int dailyWage = 0;
            int monthlyWage = 0;
            int workingHours = 0;
            int workingDays = 0;
            int employeeHours = 0;
            int[] results = new int[MAX_WORKING_DAYS+1];

            while (workingDays<MAX_WORKING_DAYS && workingHours<MAX_WORKING_HOURS)
            {
                
                Program program = new Program();
                int employeeAttendenceCheck = program.checkEmployee();
                employeeHours = program.checkEmployeeHour(employeeAttendenceCheck);
                workingHours = workingHours + employeeHours;

                //CALCULATING DAILY WAGE
                dailyWage = WAGE_PER_HOUR * employeeHours;
                results[workingDays] = dailyWage;
                monthlyWage = monthlyWage + dailyWage;
                workingDays++;
            }
            results[workingDays] = monthlyWage;
            return results;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            int[] Wages = program.calculateWageForMonth(MAX_WORKING_DAYS);
            Console.WriteLine("Monthly Employee Wage is : ");
            for (int i = 0; i < Wages.Length; i++)
            {
                Console.Write(Wages[i]+" ");   
            }
        }
    }
}
