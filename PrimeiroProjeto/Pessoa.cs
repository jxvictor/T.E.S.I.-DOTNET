using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    public class Pessoa
    {
        private string nome;
        private int idade;

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public string ObterNome() 
        { 
            return this.nome;
        }

        public int ObterIdade() 
        { 
            return this.idade;
        }
    }
}
