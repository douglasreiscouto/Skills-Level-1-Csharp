using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        string sPersonagem1, sPersonagem2;

        List <string> personagens = new List<string>();
        List<int> valores = new List<int>();

        //Console.WriteLine("Digite o nome do primeiro personagem: ");
        //sPersonagem1 = Console.ReadLine();

        //Console.WriteLine("Digite o nome do segundo personagem: ");
        //sPersonagem2 = Console.ReadLine();

        //personagens.Add(sPersonagem1);
        //personagens.Add(sPersonagem2);

        //adicionando registros a minha lista
        personagens.Add("Goku");
        personagens.Add("Homen-Aranha");
        valores.Add(1);
        valores.Add(10);
        valores.Add(50);
        valores.Add(-10);
        valores.Add(8);

        valores.Remove(-10);

        Console.WriteLine(valores.Count);

        Console.WriteLine(personagens[0]);
        Console.WriteLine(personagens[1]);
        Console.Read();
    }
}