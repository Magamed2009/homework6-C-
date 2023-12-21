var about = new Study("asd",2,4);

System.Console.WriteLine(about.Teach());

System.Console.WriteLine(about.SetExperience(12));

System.Console.WriteLine(about.GetExperience());

class Study
{
  private string name;
  private int age;
  private int grade;
  public string Name {get; set;}
  public int Age {get; set;}
  public int Grade {get; set;}
  public string Teach()
  {
    return $"{Name} is teaching {Age}";
  }
  public string SetExperience(int newGrade)
  {
    return $"{Grade}";
  }
  public string GetExperience()
  {
    return $"{Grade}";
  }
  public Study()
  {

  }
  public Study(string a,int b)
  {
    Name=a;
    Age=b;
  }
   public Study(string a,int b,int c)
  {
    Name=a;
    Age=b;
    Grade=c;
  }
}