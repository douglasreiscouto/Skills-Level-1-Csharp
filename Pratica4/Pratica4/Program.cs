using System;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            string beterraba, ovo;
            int batataC = 2, repolhoC = 1, alfaceC = 0, cenouraC = 0, resultado;   
            int queijoP = 240, batataP = 150, repolhoP = 100, alfaceP = 120, cenouraP = 70;

            Alimento alimento = new Alimento();
            alimento.Calorias("Batata", batataP, batataC);
            alimento.Falar();

        }
    }
}