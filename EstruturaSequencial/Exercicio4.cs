using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace EstruturaSequencial
{
    public class Exercicio4
    {
        int numFuncionario;
        decimal horasTrabalhadas, valorHora, salario;

        public void Exercicio(){
            Console.WriteLine("\nDigite o número do funcionário:");
            numFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQuantas horas esse funcionário trabalhou?");
            horasTrabalhadas = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nDigite o valor da hora trabalhada:");
            valorHora = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horasTrabalhadas * valorHora;
                       
            Console.WriteLine($"\nO salário do funcionário {numFuncionario} será: R${salario.ToString("F2", CultureInfo.InvariantCulture)} ");
        }
    }
}