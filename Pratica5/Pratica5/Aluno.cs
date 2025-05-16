using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica5
{
    class Aluno
    {
        public float[] afNotas = new float[8];
        float fResultado;
        //public float iNota1, iNota2, iNota3, iNota4, iNota5, iNota6, iNota7, iNota8;
        public float MediaAluno()
        {
            //fResultado = (iNota1 + iNota2 + iNota3 + iNota4 + iNota5 + iNota6 + iNota7 + iNota8) / 8;
            fResultado = (afNotas[0] + afNotas[1] + afNotas[2] + afNotas[3] + afNotas[4] + afNotas[5] + afNotas[6] + afNotas[7]) / 8;
            return fResultado;
        }

        public void fImprimeTela ()
        {
            Console.WriteLine(Environment.NewLine); //salta uma linha
            Console.WriteLine("A media do aluno é " + MediaAluno());
            Console.ReadLine();
        }
    }
}
