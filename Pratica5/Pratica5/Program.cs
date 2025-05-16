using System.Runtime.CompilerServices;
using Pratica5;

internal class Program
{
    private static void Main(string[] args)
    {
        //declarando o array e variavel
        //float[] afNotas = new float[8];[

        //int iNota1 = 10, iNota2 = 8, iNota3 = 5, iNota4 = 3, iNota5 = 6, iNota6 = 9, iNota7 = 2, iNota8 = 1;
        //string sAluno = "Douglas Couto";

        //contrutor da classe aluno 
        Aluno aluno = new Aluno();

        //Requisutar a entrada das 8 nota
        Console.Write("Digite a primeira nota: ");
        aluno.afNotas[0] = float.Parse(Console.ReadLine());
        Console.Write("Digite a segunda nota: ");
        aluno.afNotas[1] = float.Parse(Console.ReadLine());
        Console.Write("Digite a terceira nota: ");
        aluno.afNotas[2] = float.Parse(Console.ReadLine());
        Console.Write("Digita a quarta nota: ");
        aluno.afNotas[3] = float.Parse(Console.ReadLine());
        Console.Write("Digite a quinta nota: ");
        aluno.afNotas[4] = float.Parse(Console.ReadLine());
        Console.Write("Digite a sexta nota: ");
        aluno.afNotas[5] = float.Parse(Console.ReadLine());
        Console.Write("Digite a sétima nota: ");
        aluno.afNotas[6] = float.Parse(Console.ReadLine());
        Console.Write("Digite a oitava nota: ");
        aluno.afNotas[7] = float.Parse(Console.ReadLine());

        //Retornando resultado
        aluno.fImprimeTela();    

        /*
        Aluno aluno = new Aluno();
        aluno.iNota1 = iNota1;
        aluno.iNota2 = iNota2;
        aluno.iNota3 = iNota3;
        aluno.iNota4 = iNota4;
        aluno.iNota5 = iNota5;
        aluno.iNota6 = iNota6;
        aluno.iNota7 = iNota7;

        int[] asNotaAluno = new int[8]; //1 Linha e 8 Colunas
        asNotaAluno[0] = iNota1;
        asNotaAluno[1] = iNota2;
        asNotaAluno[2] = iNota3;
        asNotaAluno[3] = iNota4;
        asNotaAluno[4] = iNota5;
        asNotaAluno[5] = iNota6;
        asNotaAluno[6] = iNota7;
        asNotaAluno[7] = iNota8;
        */
    }
}