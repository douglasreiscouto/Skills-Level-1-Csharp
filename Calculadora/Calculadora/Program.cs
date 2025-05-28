using Calculadora;

internal class Program
{
    private static void Main(string[] args)
    {
        int iOpeMenu; 

        Operacao operacao = new Operacao();
        operacao.MenuCalculadora();
        operacao.SolicitaValor();
    }
}