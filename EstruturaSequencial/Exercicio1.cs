using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaSequencial
{
    public class Exercicio1
    {
        int a, b, soma;
        public void Exercicio()
        {

            Console.WriteLine("Digite o valor do primerio número inteiro");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do segundo número inteiro");
            b = int.Parse(Console.ReadLine());

            soma = a + b;

            Console.WriteLine($"A soma entre {a} e {b} é igual a: {soma}");
         }
    }
}