var about = new Teacher("asd","jvvdj",4);

System.Console.WriteLine(about.Teach());

System.Console.WriteLine(about.SetExperience(12));

System.Console.WriteLine(about.GetExperience());

class Teacher
{
  private string name;
  private string subject;
  private int experience;
  public string Name {get; set;}
  public string Subject {get; set;}
  public int Experience {get; set;}
  public string Teach()
  {
    return $"{Name} is teaching {Subject}";
  }
  public string SetExperience(int years)
  {
    return $"{Experience}";
  }
  public string GetExperience()
  {
    return $"{Experience}";
  }
  public Teacher()
  {

  }
  public Teacher(string a,string b)
  {
    Name=a;
    Subject=b;
  }
   public Teacher(string a,string b,int c)
  {
    Name=a;
    Subject=b;
    Experience=c;
  }
}