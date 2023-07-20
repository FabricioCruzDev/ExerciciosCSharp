using ExercicioConjuntos.Entities;


HashSet<Course> course = new HashSet<Course>();
HashSet<Students> student = new HashSet<Students>();
Teacher teacher = new Teacher();

Console.WriteLine("Enter teacher data:");
Console.Write("Enrollment:");
int teacherEnrollment = int.Parse(Console.ReadLine());
Console.Write("Name:");
string teacherName = Console.ReadLine();
Console.Write("How many courses this teacher has? ");
int quantity = int.Parse(Console.ReadLine());

for (int i = 0; i < quantity; i++)
{
  Console.Write("Enter course name: ");
  string nameCourse = Console.ReadLine();
  Console.WriteLine("Enter students: ");
  string[] vect = Console.ReadLine().Split(',');
  foreach (string vectStr in vect)
  {
    student.Add(new Students { Enrollment = int.Parse(vectStr) });
  }
  course.Add(new Course { Name = nameCourse, Student = student });
  Console.WriteLine($"How many students for {nameCourse}? {vect.Count()}");
}

teacher = new Teacher { Enrollment = teacherEnrollment, Name = teacherName, StudentsCount = student };

Console.WriteLine($"Total students: {student.Count()}");


