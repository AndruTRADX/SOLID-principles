namespace SingleResponsibility
{
  public class Student
  {
    public int Id { get; set; }
    public string Fullname { get; set; }
    public List<double> Grades { get; set; }

    public Student()
    {
      Fullname = string.Empty;
      Grades = new List<double>();
    }

    public Student(int id, string fullname, List<double> grades)
    {
      Id = id;
      Fullname = fullname;
      Grades = grades;
    }
  }
}