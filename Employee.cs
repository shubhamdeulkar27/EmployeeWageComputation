using System;

/// <summary>
/// Employee Class For Setting and Getting Data From Employee Object
/// </summary>
public class Employee
{
    private int dailyWage = 0;
    private int monthlyWage = 0;
    private int workingHours = 0;
    private int workingDays = 0;
    private int employeeHours = 0;
    private int employeeAttendenceCheck = 0;

    public int DailyWage { get => dailyWage; set => dailyWage = value; }
    public int MonthlyWage { get => monthlyWage; set => monthlyWage = value; }
    public int WorkingHours { get => workingHours; set => workingHours = value; }
    public int EmployeeHours { get => employeeHours; set => employeeHours = value; }
    public int EmployeeAttendenceCheck { get => employeeAttendenceCheck; set => employeeAttendenceCheck = value; }
    public int WorkingDays { get => workingDays; set => workingDays = value; }
   
}
