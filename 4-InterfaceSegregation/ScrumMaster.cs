namespace InterfaceSegregation
{
  public class ScrumMaster : IWorkTeamActivities, IDesignActivities, ITestActivities, IDevelopActivities
  {
    public ScrumMaster()
    {
    }

    public void Plan()
    {
      Console.WriteLine("I'm planning user stories");
    }

    public void Communicate()
    {
      Console.WriteLine("I'm talking to the team user");
    }

    public void Design()
    {
      Console.WriteLine("I'm designing new futures");
    }

    public void Develop()
    {
      Console.WriteLine("I'm developing the functionalities required");
    }

    public void Test()
    {
      Console.WriteLine("I'm testing the application");
    }
  }
}