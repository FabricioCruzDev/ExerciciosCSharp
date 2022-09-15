using System;

namespace CalculadoraSignos
{
    class Program
    {//Método/função principal
        static void Main(string[] args)//() -> Parâmetros
        {
            // variáveis
            string dia;
            string mes;
          
            //captura dos dados
            Console.WriteLine("Em que dia você nasceu? ");
            dia = Console.ReadLine();// atribuindo o valor a variável

            Console.WriteLine("Em que mês você nasceu? ");
            mes = Console.ReadLine();

            //Variáveis
            Int32 intDia = 0;
            Int32 intMes = 0;

            //Proteção do sistema 

                 
            try
            { //tentar converter as variáveis dia e mes em Int32 e salvar nas variáveis intDia e intMes 
                intDia = Convert.ToInt32(dia);
                intMes = Convert.ToInt32(mes);
            }
            catch (FormatException)// Se não conseguir resolver o try. Vai pegar o FormatException e executar o código a baixo.
            {
                Console.WriteLine("Não foi possível interpretar seu signo.\nVocê não digitou um dia ou um mês válido!\nTente novamenteTente novamente");
                Console.ReadLine();
                Environment.Exit(0);// saindo do sistema
            }

            if (intDia > 31 || intMes > 12)
            {
                Console.WriteLine("Data inválida!");
                Console.WriteLine("O dia deve ser menor ou igual a 31\ne o mes menor ou igual a 12");
                Environment.Exit(0);
            }


            //Acionando o método/função "Interpretar" da classe "InterpretadorSigno" e lhe atribuindo o nome "interpretador"(var).
            InterpretadorSigno interpretador = new InterpretadorSigno();

            //Vai gerar em signo o resultado gerado pelo interpretador(funçâo/metodo ".Interpretar" da classe InterpretadorSigno), através dos dados das variáveis intDia e intMes.
            Signo signo = interpretador.Interpretar((intDia), (intMes)); //Signo = classe com os atributos de cada signo e "signo" variável para salvar os dados coletados pelo interpretador

            //Se signo for diferente de null exibe o resultado na tela
            if (signo != null)
            {
                Console.WriteLine("Seu signo é " + signo.nome + " " + signo.caracteristicas + "."); // Exibe apenas o nome e características da classe signo.
            }
            else//Se não exibe a mensagem que não foi possivel encontrar o signo.
            {
                Console.WriteLine("Não foi possível interpretar seu signo.\nVocê não digitou um dia ou um mês válido!\nTente novamenteTente novamente");
            }

            //Encerramento do sistema
            Console.ReadLine();
            Console.ReadKey();

            }
    }
}
