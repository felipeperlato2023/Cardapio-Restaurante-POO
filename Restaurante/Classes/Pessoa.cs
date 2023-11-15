using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Classes
{
    internal class Pessoa
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime Datanasc { get; set; }

        public Pessoa(string nome, string cpf, DateTime datanasc)
        {
            Nome = nome;
            Cpf = cpf;
            Datanasc = datanasc;
        }
    }
}
