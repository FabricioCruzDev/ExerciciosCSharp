using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace EstruturaSequencial
{
    public class Exercicio2
    {
        double raio, area = 0;
        const double Pi = 3.14159;

        public void Exercicio()
        {
            Console.WriteLine("Digite o valor do raio do círculo:");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = Pi * Math.Pow(raio, 2);
            Console.WriteLine($"Área = PI({Pi}) . raio({raio})² = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }

    }
}