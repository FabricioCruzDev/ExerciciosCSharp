using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioConjuntos.Entities
{
  public class Students
  {
    public int Enrollment { get; set; }

    public override int GetHashCode()
    {
      return Enrollment.GetHashCode();
    }

    public override bool Equals(object obj)
    {
      if (!(obj is Students)) return false;

      Students other = obj as Students;
      return Enrollment.Equals(other.Enrollment);
    }
  }
}