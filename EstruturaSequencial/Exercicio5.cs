using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace EstruturaSequencial
{
    public class Exercicio5
    {
        int codigoPeca, quantidadePecas;
        decimal valorUnitario, valorTotal;

        public void Exercicio(){
            Console.WriteLine("\nDigite o código da peça:");
            codigoPeca = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme a quantidade de peças:");
            quantidadePecas = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o valor da peça:");
            valorUnitario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valorTotal = quantidadePecas * valorUnitario;

            Console.WriteLine("\nDigite o código da peça:");
            codigoPeca = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme a quantidade de peças:");
            quantidadePecas = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o valor da peça:");
            valorUnitario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valorTotal += quantidadePecas * valorUnitario;
            Console.WriteLine($"Valor a pagar = R${valorTotal.ToString(CultureInfo.InvariantCulture)}.");
        }
    }
}