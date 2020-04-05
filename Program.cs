using System;
using System.Collections.Generic;

namespace EmployeeWageComputation
{
    class Program
    {
        //CONSTANTS
        private const int IS_PART_TIME = 1;
        private const int IS_FULL_TIME = 2;
        private const int PART_TIME_HOURS = 4;
        private const int FULL_TIME_HOURS = 8;
        private const int WAGE_PER_HOUR = 20;
        private const int MAX_WORKING_DAYS = 20;
        private const int MAX_WORKING_HOURS = 100;

        /// <summary>
        /// FUNCTION TO CHECK EMPLOYEE ATTENDENCE RANDOMLY
        /// USES RANDOM CLASS'S NEXT FUNCTION
        /// </summary>
        /// <returns></returns>
        public int CheckEmployee()
        {
            Random random = new Random();
            int randomCheck = random.Next(3);
            return randomCheck;
        }

        /// <summary>
        /// FUNCTION TO CHECK EMPLOYEE WORKING HOURS
        /// </summary>
        /// <param name="employeeAttendenceCheck"></param>
        /// <returns></returns>
        public int CheckEmployeeHour(int employeeAttendenceCheck) 
        {
            int employeeHours = 0;
            switch (employeeAttendenceCheck)
            {
                case IS_FULL_TIME:
                    employeeHours = FULL_TIME_HOURS;
                    break;
                case IS_PART_TIME:
                    employeeHours = PART_TIME_HOURS;
                    break;
                default:
                    employeeHours = 0;
                    break;
            }
            return employeeHours;
        }

        /// <summary>
        /// FUNCTION FOR CALCULATING MONTHLY WAGES
        /// </summary>
        /// <param name="MAX_WORKING_DAYS"></param>
        /// <returns></returns>
        public Dictionary <string,int> CalculateWageForMonth(int MAX_WORKING_DAYS) 
        {
            Employee employee = new Employee();
            Dictionary<string,int> results = new Dictionary<string, int>();
            while (employee.WorkingDays<MAX_WORKING_DAYS && employee.WorkingHours<MAX_WORKING_HOURS)
            {
                employee.WorkingDays++;
                Program program = new Program();
                employee.EmployeeAttendenceCheck = program.CheckEmployee();
                employee.EmployeeHours = program.CheckEmployeeHour(employee.EmployeeAttendenceCheck);
                employee.WorkingHours = employee.WorkingHours + employee.EmployeeHours;
 
                //CALCULATING DAILY WAGE AND MONTHLY WAGE
                employee.DailyWage = WAGE_PER_HOUR * employee.EmployeeHours;
                results[$"Day {employee.WorkingDays}"] = employee.DailyWage;
                employee.MonthlyWage = employee.MonthlyWage + employee.DailyWage;
            }
            results["Monthly Wage"] = employee.MonthlyWage;
            return results;
        }

        /// <summary>
        /// MAIN FUNCTION CALCULATE WAGES FOR MONTH AND STORE IT TO DICTIONARY
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program program = new Program();
            Dictionary <string,int> Wages = program.CalculateWageForMonth(MAX_WORKING_DAYS);
            Console.WriteLine("Monthly Employee Wage is : ");
            foreach (KeyValuePair<string, int> kv in Wages)
            {
                Console.WriteLine(kv.Key+"-"+kv.Value);
            }
        }
    }
}