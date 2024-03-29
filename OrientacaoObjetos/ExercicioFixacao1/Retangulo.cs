using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioFixacao1
{
  public class Retangulo
  {
    public double Largura;
    public double Altura;

    public double Area()
    {
      return Largura * Altura;
    }

    public double Perimetro()
    {
      return (Largura * 2) + (Altura * 2);
    }

    public double Diagonal()
    {
      return Math.Sqrt(Math.Pow(Largura, 2) + (Math.Pow(Altura, 2)));
    }
  }
}