using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAlunos
{
    internal class aluno
    {
        public Guid Matricula { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }

        public string ExibirAlunos()
        {
            return ($" Aluno: {Nome}\n Matricula: {Matricula}\n Idade: {CalcularIdade(DataNascimento)}\n Cpf:  {Cpf}\n");

        }
        public int CalcularIdade(DateTime DataNascimento)
        {
            int idade = DateTime.Today.Year - DataNascimento.Year;

           return idade;
        }
        public aluno(string nome, DateTime dataNascimento,string cpf)
        {
            Matricula = Guid.NewGuid();
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf; 
        }


    
  


    } }


