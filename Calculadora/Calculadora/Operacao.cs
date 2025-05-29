using System;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Collections.Generic;

namespace Calculadora
{
    class Operacao
    {
        //variaveis
        int iOpeMenu;
        float fValorUm, fValorDois, fResultado;

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

            if (iOpeMenu != 0)
            {
                SolicitaValor(iOpeMenu);
            }
            else 
            {
                Console.WriteLine("****PRECIONE QUALQUER TECLA PARA SAIR****");
                Console.Read();
            }
        }

        private void SolicitaValor(int iOpeMenu)
        {
            Console.Write("Digite o primeiro valor: ");
            fValorUm = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            fValorDois = float.Parse(Console.ReadLine());

            if (iOpeMenu == 1)
            {
                Soma(fValorUm, fValorDois);
            }
            else if (iOpeMenu == 2)
            {
                Subtrair(fValorUm, fValorDois);
            }
            else if (iOpeMenu == 3)
            {
                Multiplicacao(fValorUm, fValorDois);
            }
            else
            {
                Divisao(fValorUm, fValorDois);
            }

        }

        private void RetornaResultado(float fResultado, int iOpeMenu)
        {
            if (iOpeMenu == 1)
            {
                Console.WriteLine();
                Console.Write("RESULTADO DA SOMA: " + fResultado);
                Console.WriteLine();
                ChamaOutraOperacao();

            }
            else if (iOpeMenu == 2)
            {
                Console.WriteLine();
                Console.WriteLine("RESULTADO DA SUBTRAÇÃO: " + fResultado);
                Console.WriteLine();
                ChamaOutraOperacao();
            }
            else if (iOpeMenu == 3)
            {
                Console.WriteLine();
                Console.Write("RESULTADO DA MULTIPLICAÇÃO: " + fResultado);
                Console.WriteLine();
                ChamaOutraOperacao();
            }
            else
            {
                Console.WriteLine();
                Console.Write("RESULTADO DA DIVISÃO: " + fResultado);
                Console.WriteLine();
                ChamaOutraOperacao();
            }
        }
        private void Soma(float fValorUm, float fValorDois)
        {
            fResultado = fValorUm + fValorDois;
            RetornaResultado(fResultado, 1);

        }
        private void Subtrair(float fValorum, float fValorDois)
        {
            fResultado = fValorum - fValorDois;
            RetornaResultado(fResultado, 2);
        }
        private void Multiplicacao(float fValorUm, float fValorDois)
        {
            fResultado = fValorUm * fValorDois;
            RetornaResultado(fResultado, 3);
        }
        private void Divisao(float fValorUm, float fValordois)
        {
            if (fValorUm == 0 || fValordois == 0)
            {   
                Console.Clear();
                Console.WriteLine("Não é possível dividir por ZERO!");
                Console.WriteLine("****SELECIONE NOVOS VALORES****");
                Console.WriteLine();
                SolicitaValor(4);
            }
            else
            {
                fResultado =  fValorUm / fValordois;
                RetornaResultado(fResultado, 4);
            }
        }
        
        private void ChamaOutraOperacao()
        {
            int iChamaOutraOp;

            Console.WriteLine();
            Console.WriteLine("Deseja fazer outro operação?");
            Console.WriteLine("1 - SIM");
            Console.WriteLine("2 - NÃO");
            Console.Write("--> ");
            iChamaOutraOp = int.Parse(Console.ReadLine());

            if (iChamaOutraOp == 1)
            {
                Console.Clear();
                MenuCalculadora();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("****PRECIONE QUALQUER TECLA PARA SAIR****");
                Console.Read();

            }
        }

    }
}