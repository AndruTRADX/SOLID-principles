namespace InterfaceSegregation
{
  public class Tester : IWorkTeamActivities, ITestActivities
  {
    public Tester()
    {
    }

    public void Plan()
    {
      throw new ArgumentException();
    }

    public void Communicate()
    {
      throw new ArgumentException();
    }

    public void Test()
    {
      throw new ArgumentException();
    }
  }
}