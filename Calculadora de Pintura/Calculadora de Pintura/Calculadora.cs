using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Pintura
{
    class Calculadora
    {
        //definição das varáveis
        private double areaParedes;
        private double areaTeto;
        private double areaTotal;
        private double totalTinta;

        public double AreaParede(double largura, double profundidade, double altura, double rendimento)
        {
           areaParedes = 2 * (largura + profundidade) * altura;
           return areaParedes;
           
        }
        public double AreaTeto(double largura, double profundidade)
        {
            areaTeto = largura * profundidade;
            return areaTeto;
        }
        public double AreaTotal()
        {
            areaTotal = areaTeto + areaParedes;
            return areaTotal;
        }
        public double Rendimento(double rendimento)

        {
            totalTinta = areaTotal  / rendimento;

                if (areaParedes == 0 && areaTeto == 0)
                {
                    Console.WriteLine("Não foi possível calcular!");
                    Console.ReadLine();
                    Environment.Exit(1);
                }
                return totalTinta;
        }
      


    }
}
