using System;

namespace Calculadora_de_Pintura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de tintas\n");

            //Imput
            Console.WriteLine("\nInforme a largura do cômodo: ");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a profundidade do cômodo: ");
            double profundidade = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura do cômodo: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o rendimento da tinta, de acordo com as informações do fabricante: ");
            double rendimento = double.Parse(Console.ReadLine());

            //calculo
            Calculadora calculadora = new Calculadora();


            Console.WriteLine("A área das paredes é: " + calculadora.AreaParede(largura, profundidade, altura, rendimento) +"m2");

            Console.WriteLine("A área do teto é: " + calculadora.AreaTeto(largura, profundidade) + "m2");

            Console.WriteLine("\nA área total a ser pintada é: " + calculadora.AreaTotal() + " m2");

            Console.WriteLine("\nVocê vai precisar de: " + calculadora.Rendimento(rendimento) + "Lts de tinta.");

            Console.ReadLine();


            
        }
    }
}
