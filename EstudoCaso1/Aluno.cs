using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCaso1
{
    class Aluno
    {
        public string nome, curso;
        public int matricula, dtNascimento, idade;
        public string CadastroAluno(String nome, int matricula, int dtNascimento, string curso)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.dtNascimento = dtNascimento;
            this.curso = curso;
            return "Cadastro realizado com sucesso!";
        }
    }
    class Calculadora
    {
        public int nota1, nota2, nota3, dtNascimento;
        public int anoAtual = DateTime.Now.Year;
        public int CalcularIdade(int dtNascimento, int anotAtual)
        {
            return anoAtual - dtNascimento;
        }
        public int CalculaMedia(int nota1, int nota2, int nota3)
        {
            int media = (nota1 + nota2 + nota3) / 3;
            return media;
        }
    }
}
