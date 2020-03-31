using System;

namespace EmployeeWageComputation
{
    class Program
    {
        //CONSTANTS
        private const int IS_PART_TIME = 1;
        private const int IS_FULL_TIME = 2;
        private const int WAGE_PER_HOUR = 20;

        //FUNCTION TO CHECK EMPLOYEE ATTENDENCE RANDOMLY
        public int checkEmployee()
        {
            Random random = new Random();
            int randomCheck = random.Next(3);
            return randomCheck;
        }
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
        static void Main(string[] args)
        {   
            //VARIABLE
            int employeeHours = 0;
            int dailyWage = 0;

            Program program = new Program();
            int employeeAttendenceCheck = program.checkEmployee();
            employeeHours=program.checkEmployeeHour(employeeAttendenceCheck);

            //CALCULATING DAILY WAGE
            dailyWage = WAGE_PER_HOUR * employeeHours;
            Console.WriteLine($"Daily Employee Wage is {dailyWage}");
        }
    }
}
