using System;

namespace EmployeeWageComputation
{
    class Program
    {
        
        //FUNCTION TO CHECK EMPLOYEE ATTENDENCE RANDOMLY
        public int checkEmployee()
        {
            Random random = new Random();
            int randomCheck = random.Next(3);
            return randomCheck;
        }
        static void Main(string[] args)
        {   //CONSTANTS
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int WAGE_PER_HOUR = 20;

            //VARIABLE
            int employeeHours = 0;
            int dailyWage = 0;

            Program program = new Program();
            int employeeAttendenceCheck = program.checkEmployee();

            if (employeeAttendenceCheck == IS_FULL_TIME)
            {
                employeeHours = 8;
            }
            else if (employeeAttendenceCheck == IS_PART_TIME)
            {
                employeeHours = 4;
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
