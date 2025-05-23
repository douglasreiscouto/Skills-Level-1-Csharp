using System.Runtime.CompilerServices;

namespace TesstesDiversos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //contrutor da classe
            Personagem pesonagem = new Personagem();
            //criando vertor a partir de uma classe
            Personagem[] vetorPersonagens = new Personagem[2];

            vetorPersonagens[0] = new Personagem();
            vetorPersonagens[0].nome = "Douglas";
            vetorPersonagens[0].level = 1;

            vetorPersonagens[1] = new Personagem();
            vetorPersonagens[1].nome = "Monique";
            vetorPersonagens[1].level = 6;

            //declarando um vetores
            int[] meuVetor;
            meuVetor = new int[12];

            //atribuindo valor para o vetor - set
            meuVetor[0] = 1;
            meuVetor[1] = 12;
            meuVetor[2] = 50;
            meuVetor[3] = 1010;
            meuVetor[4] = 200;

            string[] diasDaSemana = { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado", "Domingo" };
            string[] mesesPrimeiroSemestre = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho" };


            //recuperando valor - get 
            Console.WriteLine(vetorPersonagens.Length); //mostra o tamanho do array
            Console.WriteLine(vetorPersonagens[1].level); //mostrar o tamanho do array

            Console.ReadLine();

        }

    }
    class Personagem ()
    {
        public string nome;
        public int level;
    }
}