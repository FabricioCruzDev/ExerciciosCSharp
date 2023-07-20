using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioConjuntos.Entities
{
  public class Teacher
  {
    public int Enrollment { get; set; }
    public string Name { get; set; }
    public HashSet<Students> StudentsCount { get; set; }

  }

}