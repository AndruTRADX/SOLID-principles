namespace OpenClose;

public class EmployeeContractor : Employee
  {
    public EmployeeContractor(string fullname, int hoursWorked)
    {
      Fullname = fullname;
      HoursWorked = hoursWorked;
    }

    public override decimal CalculateSalaryMonthly()
    {
      decimal hourValue = 28000M;
      decimal salary = hourValue * HoursWorked * hourValue;
      return salary;
    }
  }