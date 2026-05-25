

Seasons w;
w.temperage = -16;
w.name = "winter";
double description= w.WeatherInformation();
Console.WriteLine(description);
  //первое задание
  void readfiles(){
   var students = new List<Student>
   {
       new("alexsandr", "Korshunov",35,6,4.77),
       new("alexsandra", "Emelyanova",17,1,4.45),
       new("alexei", "Korshunov",30,6,4.22),
       new("Oleg", "Korshunov",27,6,4.56),
       new("michael", "Greysenbeg",23,3,4.33),
       new("alexsandr", "Michelson",16,1,4.42),
       new("alexsandra", "Korshunova",32,6,4.10),
       new("alexsandr", "Korshunov",35,6,4.77),
       new("evgenya", "Korshunova",16,1,3.8),
       new("Ronald", "Ly army",16,1,3.33),

   };
   //первое задание
   var topBestStudents = students.Where(s=> s.averageGrade > 4.10);
   foreach(var s in topBestStudents)
   {
      Console.WriteLine($"оценка студента и его данные: {s.name} {s.lastname} {s.course} {s.age} {s.averageGrade}");        
   }
   var grades = new[]  {4.77,4.45,4.22,4.56,4.33,4.42,4.10,4.77,3.8,3.33};
   Console.WriteLine($"средняя оуценка студентов {grades.Average()}");
   var studentsbuntars = students
      .Where(s =>s.averageGrade < 4.10)
      .OrderBy(s => s.name)
      .OrderBy(s => s.lastname)
      .OrderBy(s => s.course);
    foreach( var s in studentsbuntars)
    {
      Console.WriteLine($"оценка студента и его данные: {s.name} {s.lastname} {s.course} {s.age} {s.averageGrade}");       
    }
  }
 readfiles();



 struct Seasons
{    public string name;
     public double temperage;
   
    public Seasons(string name,double temperage)
    {
       this.name = name;
       this.temperage = temperage;
    }
    public double WeatherInformation()
    {
        if (temperage > 5)
        {
            Console.WriteLine("на улице Холодная осень");
        }
        else if(temperage < -8)
        {
            Console.WriteLine("На улице зима");
        }
        else if(temperage > 15)
        {
            Console.WriteLine("На улице прохлажная весна");
        }
        else if(temperage < 12)
        {
            Console.WriteLine("На улице осень");
        }
        else if(temperage < 25)
        {
            Console.WriteLine("На улице тепла весна");
        }
        else if(temperage > 25 )
        {
            Console.WriteLine("На улице лето");
        }
        return temperage;
        

    }
}
class Student(string name, string lastname, int age,int course,double averageGrade)
{
    public string name = name;
    public string lastname = lastname;
    public int age = age;
    public int course = course;
    public double averageGrade = averageGrade;

}
