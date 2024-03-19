using SingleResponsibility;

StudentRepository studentRepository = new();
ExportHelper<Student> studentExport = new();

studentExport.ExportToCSV(studentRepository.GetAll());

Console.WriteLine("Proceso Completado");