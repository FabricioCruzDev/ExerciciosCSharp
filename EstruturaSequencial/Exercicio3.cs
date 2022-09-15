using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaSequencial
{
    public class Exercicio3
    {
        int a, b, c, d, produtoAB, produtoCD;
        public void Exercicio()
        {

            Console.WriteLine("Digite o valor de A");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de D");
            d = int.Parse(Console.ReadLine());

            produtoAB = a * b;

            produtoCD = c * d;

            Console.WriteLine($"A diferença entre os produtos de AB ({produtoAB}) e CD ({produtoCD}) é igual a: {produtoAB - produtoCD}");
        }
    }
}