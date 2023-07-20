using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioConjuntos.Entities
{
  public class Course
  {
    public string Name { get; set; }

    public HashSet<Students> Student { get; set; }

    public override int GetHashCode()
    {
      return Name.GetHashCode();
    }

    override public bool Equals(object obj)
    {
      if (!(obj is Students))
      {
        return false;
      }
      Course other = obj as Course;
      return Name.Equals(other.Name);
    }
  }
}