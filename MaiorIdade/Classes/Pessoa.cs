using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorIdade.Classes
{
    class Pessoa
    {
        public string nome;
        public int idade;

        /// <summary>
        /// método com parâmetros
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="idade"></param>
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        /// <summary>
        /// método sem parâmetros
        /// </summary>
        public Pessoa()
        {

        }
       
    
        public void ExibirDados(string nome, string idade)
        {
            
        }
    }
}
