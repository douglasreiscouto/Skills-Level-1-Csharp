using System;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {

            Alimento alimento = new Alimento();
            alimento.resultado = alimento.Calorias(5, 3);
            alimento.Falar();

        }
    }
}