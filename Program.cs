using System;

namespace EmployeeWageComputation
{
    class Program
    {
        
        //FUNCTION TO CHECK EMPLOYEE ATTENDENCE RANDOMLY
        public int checkEmployee()
        {
            Random random = new Random();
            int randomCheck = random.Next(2);
            return randomCheck;
        }
        static void Main(string[] args)
        {   //CONSTANTS
            int IS_PRESENT = 1;
            int WAGE_PER_HOUR = 20;

            //VARIABLES
            int employeeAttendence = 0;
            int employeeHours = 0;
            int dailyWage = 0;

            Program program = new Program();
            int employeeAttendenceCheck = program.checkEmployee();

            if (employeeAttendenceCheck == IS_PRESENT)
            {
                employeeHours = 8;
            }
            else
            {
                employeeHours = 0;
            }

            dailyWage = WAGE_PER_HOUR * employeeHours;
            Console.WriteLine($"Daily Employee Wage is {dailyWage}");
        }
    }
}
