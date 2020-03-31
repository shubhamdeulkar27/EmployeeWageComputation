using System;

namespace EmployeeWageComputation
{
    class Program
    {
        
        public int checkEmployee()
        {
            Random random = new Random();
            int randomCheck = random.Next(2);
            return randomCheck;
        }
        static void Main(string[] args)
        {
            int IS_PRESENT = 1;
            int employeeAttendence = 0;
            Program program = new Program();
            int employeeAttendenceCheck = program.checkEmployee();
            if (employeeAttendenceCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee Is Not Present");
            }
        }
    }
}
