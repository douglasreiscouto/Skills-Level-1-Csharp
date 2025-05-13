using EstudoCaso1;

internal class Program
{
    private static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        Calculadora aluno2 = new Calculadora();
        
        Console.WriteLine(aluno1.CadastroAluno("Douglas", 100, 1997, "ADS"));  
        Console.WriteLine(aluno2.CalculaMedia(10, 4, 8));    



    }
}