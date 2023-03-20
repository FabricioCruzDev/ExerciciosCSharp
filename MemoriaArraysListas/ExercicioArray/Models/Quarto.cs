using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioArray
{
    public class Quarto
    {
        public int Numero { get; set; }
        public bool Ocupado { get; set; }
        public string Hospede { get; set; }
        public string Email { get; set; }

        public Quarto(string nome, string email, int quarto)
        {
            Hospede = nome;
            Email = email;
            Numero = quarto;
        }
        public Quarto()
        {
            
        }

        public override string ToString()
        {
            return "Quarto: "
                    + Numero +
                    " Hospede: "
                    + Hospede +
                    " Email: "
                    + Email +
                    ".\n";
        }

    }
}