using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operacao
    {
        float Soma(float fValorUm, float fValorDois)
        {
            return fValorUm + fValorDois;
        }
        float Subtrair(float fValorum, float fValorDois)
        {
            return fValorum - fValorDois;
        }
        float Multiplicacao(float fValorUm, float fValorDois)
        {
            return fValorUm * fValorDois;
        }
        float Divisao(float fValorUm, float fValordois)
        {
            return fValorUm / fValordois;
        }
    }
}
