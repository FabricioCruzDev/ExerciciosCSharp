using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioFixacao3
{
  public class Aluno
  {
    public string Nome;
    public double NotaTrimestre1;
    public double NotaTrimestre2;
    public double NotaTrimestre3;

    public double NotaFinal()
    {
      return NotaTrimestre1 + NotaTrimestre2 + NotaTrimestre3;
    }

    public bool Aprovado()
    {
      if (NotaFinal() >= 60.0)
        return true;
      else
      {
        return false;
      }
    }

    public double NotaRestante()
    {
      if (Aprovado())
        return 0.0;
      else
        return 60.0 - NotaFinal();
    }
  }
}
