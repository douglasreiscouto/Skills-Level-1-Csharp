using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operacao
    {
        int iOpeMenu;
        float fValorUm, fValorDois, fResultado;
        public void SolicitaValor() 
        {
            Console.WriteLine();
            Console.Write("Digite o Primeiro Valor: ");
            fValorUm = float.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo Valor: ");
            fValorDois = float.Parse(Console.ReadLine());
        }
        public void MenuCalculadora()
        {
            Console.WriteLine("****MENU DE OPERAÇÕES****");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Digite o número da operação desejada: ");
            iOpeMenu = int.Parse(Console.ReadLine());
        }

        public void RetornaResultado(float fResultado, int iOpeMenu)
        {
            if (iOpeMenu == 1)
            {
                Console.Write("RESULTADO DA SOMA: " + fResultado);
            }
            else if (iOpeMenu == 2)
            {
                Console.Write("RESULTADO DA SUBTRAÇÃO: " + fResultado);
            }
            else if (iOpeMenu == 3) 
            {
                Console.Write("RESULTADO DA MULTIPLICAÇÃO: " + fResultado);
            }
            else if (iOpeMenu == 4)
            {
                Console.Write("RESULTADO DA DIVISÃO: " + fResultado);
            }
            else if (iOpeMenu == 0)
            {
                Operacao menu = new Operacao();
                menu.MenuCalculadora();
            }
        }
        public void Soma()
        {
            Operacao soma = new Operacao();

            fResultado = fValorUm + fValorDois;
            soma.RetornaResultado(fResultado, 1);

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
