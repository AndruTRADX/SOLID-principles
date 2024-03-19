using OpenClose;

showSalaryMonthly(new List<Employee>() {
  new EmployeeFullTime("Pepito Pérez", 160),
  new EmployeePartTime("Manuel Lopera", 180)
});

static void showSalaryMonthly(List<Employee> employees) 
{
  foreach (var employee in employees) {
    Console.WriteLine($"Empleado: {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly()}");
  }

}