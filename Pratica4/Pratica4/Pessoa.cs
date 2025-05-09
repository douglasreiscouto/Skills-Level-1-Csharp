using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    class Pessoa
    {
        public int codigo;
        public string nome;

        public Pessoa(string nome_argumento)
        {
            Console.WriteLine("****ENTREI NO CONSTRUTOR DE UM ARGUMENTO****");
            nome = nome_argumento;
        }

        public Pessoa(string nome_argumento, int codigo_argumento)
        {
            Console.WriteLine("****ENTREI NO CONSTRUTOR DE DOIS ARGUMENTO****");
            nome = nome_argumento;
            codigo = codigo_argumento;
        }
        public void Falar()
        {
            Console.WriteLine("Meu nome é " + nome + " e meu código é " + codigo);
        }
    }
    class Alimento
    {
        public string nome;
        public int resultado;

        public int Calorias(string nome, int porcao, int kcal)
        {
            return porcao * kcal;
            
        }
        public string Calorias(string nome)
        {
            return nome;
        }
        public string Calorias(string nome, int porcao)
        {
            return nome + " " + porcao; 
        }
        public void Falar()
        {
            Console.WriteLine("O " + nome + " contém " + resultado + " de calorias!");
        }
    }
}
